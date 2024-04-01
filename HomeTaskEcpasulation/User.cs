namespace HomeTaskEcpasulation;
internal class User
{
    string _name = "Shahin";
    string _surname = "AAlizde  ";
    string _username;
    string _password = "12345678";
    public string Password
    {
        set
        {
            if (Checkpasleng(value) && CheckPasDigit(value) && CheckPasBig(value) && CheckPasSmall(value))
            {
                _password = value;
            }
            else
                Console.WriteLine("parol uygun deyil");
        }
    }
    public User(string name, string surname, string password)
    {
        Name = name;
        Surname = surname;

        _username = String.Concat(Name.Substring(0, 3), '.', Surname.Substring(0, 3));
        Password = password;
    }
    #region username
    public string Username
    {
        get { return _username; }
    }
    #endregion
    #region Name
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (CheckLetter(value.Trim()) && Name.Length > 2 && Name.Length < 25)
            {
                _name = Capitalize(value);
            }
            else
            {
                Console.WriteLine("ad duzgun deyil");
            }
        }
    }
    #endregion
    #region Surname
    public string Surname
    {
        get
        {
            return _surname;
        }
        set
        {
            if (CheckLetter(value.Trim()) && Surname.Length > 2 && Surname.Length < 25)
            {
                _surname = Capitalize(value);
            }
            else
            {
                Console.WriteLine("soyad duzgun deyil");
            }
        }

    }
    #endregion
    private string Capitalize(string name)
    {
        name = name.Trim();
        return String.Concat(name.Substring(0, 1).ToUpper(), name.Substring(1).ToLower());
    }
    private bool CheckLetter(string name)
    {
        for (int i = 0; i < name.Length; i++)
        {
            if (!Char.IsLetter(name[i]))
            {
                return false;
            }
        }
        return true;
    }
    private bool Checkpasleng(string passwoed)
    {
        if (passwoed.Length > 7)
        {
            return true;
        }
        return false;
    }
    private bool CheckPasSmall(string passwoed)
    {
        for (int i = 0; passwoed.Length > 0; i++)
        {
            if (Char.IsLower(passwoed[i]))
            { return true; }
        }
        return false;
    }
    private bool CheckPasBig(string passwoed)
    {
        for (int i = 0; passwoed.Length > 0; i++)
        {
            if (Char.IsUpper(passwoed[i]))
            { return true; }
        }
        return false;
    }
    private bool CheckPasDigit(string passwoed)
    {
        for (int i = 0; passwoed.Length > 0; i++)
        {
            if (Char.IsDigit(passwoed[i]))
            { return true; }
        }
        return false;
    }
    public void ChangePass(string oldpass, string newpass)
    {
        if (_password == oldpass)
        {
            Password = newpass;
        }
    }
}
