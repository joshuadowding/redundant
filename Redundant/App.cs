using Redundant.Models;

using System;
using System.IO;
using System.Windows.Forms;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Redundant {
    /// <summary>
    /// ...
    /// </summary>
    public static class App {
        public const string FILE_EXTENSION = ".json";

        public static SessionModel Local;

        [STAThread]
        public static void Main(string[] args) {
            Local = new SessionModel();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Instance());
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Save(string fileName) {
            try {
                JsonSerializer serializer = new JsonSerializer {
                    NullValueHandling = NullValueHandling.Ignore
                };

                using(StreamWriter stream = new StreamWriter(fileName)) {
                    using(JsonWriter writer = new JsonTextWriter(stream)) {
                        writer.Formatting = Formatting.Indented;
                        serializer.Serialize(writer, App.Local);
                    }
                }
                return true;
            }
            catch(Exception exception) {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool Load(string fileName) {
            try {
                using(StreamReader stream = File.OpenText(fileName)) {
                    JObject parsed = (JObject)JToken.ReadFrom(new JsonTextReader(stream));
                    SessionModel session = parsed.ToObject<SessionModel>();
                    App.Local = session;
                }
                return true;
            }
            catch(Exception exception) {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <returns></returns>
        public static int GenerateID() {
            Random random = new Random(Environment.TickCount);
            int[] numbers = new int[3];
            for(int index = 0; index < 2; index++) {
                numbers[index] = random.Next(100, 300);
            }
            int id = numbers[0] + numbers[1] + numbers[2];
            return id;
        }
    }

    /// <summary>
    /// ...
    /// </summary>
    public class Instance : ApplicationContext {
        public Forms.BrowseView browse;

        public Instance() {
            Application.ApplicationExit += OnApplicationClosed;

            //TODO: Startup.

            /*
            welcome = new Forms.Welcome();
            welcome.FormClosing += OnFormClosing;
            welcome.FormClosed += OnFormClosed;
            welcome.Show();
            */

            browse = new Forms.BrowseView();
            browse.FormClosing += OnFormClosing;
            browse.FormClosed += OnFormClosed;
            browse.Show();
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnApplicationClosed(object sender, EventArgs args) {
            
        }
        
        /// <summary>
        /// ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnFormClosing(object sender, EventArgs args) {
            
        }

        /// <summary>
        /// ...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnFormClosed(object sender, EventArgs args) {
            ExitThread();
        }
    }
}
