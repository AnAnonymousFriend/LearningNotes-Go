using Stylet;


namespace ToolMagazine.Pages
{
    public class ShellViewModel : Screen
    {

        private string email { get; set; }

        public string Email
        {
            get { return email; }

            set
            {
                if (email != value)
                {
                    this.email = value;
                    SetName(email);

                    //OnPropertyChanged(nameof(Email));
                    //NotifyPropertyChanged(Email);
                }

            }
        }


        private string _name { get; set; } = "waku";

        public string Name
        {
            get { return _name; }

            set
            {              
                if (_name != value)
                {
                    this._name = value;             
                    //OnPropertyChanged(Name);
                    
                }

            }
        }

        private void SetName(string name)
        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
            {
                this.Name = "邮箱格式不正确";
            }
            else
            {
                this.Name = "";
            }
           
        }

        //private void NotifyPropertyChanged(string email)
        //{
        //    if (email!="")
        //    {
        //        Name = "操作成功";
        //    }
        //    this.Name = email;

        //}


        public void SayHello() => Name = "Hello " + Name;    // C#6的语法, 表达式方法

        public bool CanSayHello => !string.IsNullOrEmpty(Name);  // 同上

    }
}
