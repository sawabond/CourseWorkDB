using System;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkDB
{
    public class AutomationTask
    {
        private string _userName, _userPassword;
        private StringBuilder _recommendationLetterText;
        public string ReceiverName { get; set; } = "oleksandr.bondarenko3@nure.ua";
        private RecommendationsForm _recommendationForm;
        public AutomationTask(RecommendationsForm form)
        {
            _recommendationForm = form;
        }
        /// <summary>
        /// Logic of email-password setting for smtp client
        /// </summary>
        private void SetNameAndPassword()
        {
            _userName = "conditer.department.automation@gmail.com";
            _userPassword = "123!@#qweQWE";
        }
        public void PerformAutomation()
        {
            CollectRecommendations();
            SetNameAndPassword();
            CreateRecommendationLetterText();
            SendEmail();
        }
        public async void SendEmail()
        {
            var sender = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = _userName,
                    Password = _userPassword
                }
            };

            var fromEmail = new MailAddress("conditer.department.automation@gmail.com",
                "Рекомендації");
            var toEmail = new MailAddress(ReceiverName, "BOSS666");
            var mailMessage = new MailMessage()
            {
                From = fromEmail,
                Subject = "Рекомендації щодо збільшення прибутку",
                Body = _recommendationLetterText.ToString()
            };
            mailMessage.To.Add(toEmail);

            try
            {
                await Task.Run(() => sender.Send(mailMessage));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void CreateRecommendationLetterText()
        {
            _recommendationLetterText = new StringBuilder();

            if (_recommendationForm.dgMostPopularDesserts.Rows.Count == 0)
            {
                _recommendationLetterText.Append("За останній тиждень не було здійснено заказів, " +
                    "тож неможливо здійснити формування рекомендацій.");
                return;
            }

            _recommendationLetterText.Append($"Рекомендації від {DateTime.Now.ToString("dd.MM.yyyy")}\n");
            _recommendationLetterText.Append("Ці десерти купувалися найчастіше за останні 7 днів\n");
            _recommendationLetterText.Append("Збільшення їх закупок допоможе збільшити прибуток\n");
            _recommendationLetterText.Append("Артикул\tКількість_покупок\n");

            for (var i = 0; i < _recommendationForm.dgMostPopularDesserts.Rows.Count - 1; i++)
            {
                for (var j = 0; j < _recommendationForm.dgMostPopularDesserts.Columns.Count; j++)
                {
                    _recommendationLetterText.Append(
                        _recommendationForm.dgMostPopularDesserts[j, i].Value.ToString());
                    _recommendationLetterText.Append('\t');
                }
                _recommendationLetterText.Append('\n');
            }

            _recommendationLetterText.Append("\nЦей лист був створений автоматично програмою 'Кондитерський відділ'\n");
            _recommendationLetterText.Append("Дякуємо, що користуєтеся нашим додатком!");
        }
        private void CollectRecommendations()
        {
            using (var conn = new SqlConnection(Main.CONNECTION_STRING))
            {
                var da = new SqlDataAdapter
                    (
                    "SELECT TOP 25 PERCENT dp.articul Артикул, COUNT(dp.articul) Кількість_покупок FROM " +
                    "DESSERT_PURCHASE as dp INNER JOIN PURCHASE as p " +
                    "ON dp.purchase_id = p.purchase_id  INNER JOIN DESSERTS as d " +
                    "ON dp.articul = d.articul WHERE DATEADD(day, 7, p.purchase_date) > GETDATE() GROUP BY dp.articul", conn
                    );
                var ds = new DataSet();
                da.Fill(ds);

                _recommendationForm.dgMostPopularDesserts.DataSource = ds?.Tables[0];
            }
        }
    }
}
