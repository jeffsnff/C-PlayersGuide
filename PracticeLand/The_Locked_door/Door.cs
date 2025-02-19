using System;
using System.Data;

namespace The_Locked_Door
{
  internal class Door
  {
    public Status _status = Status.Locked;
    string _password;

    public Door(string password)
    {
      _password = password;
    }

    public void UpdateStatus(Status status)
    {
      _status = status;
      Console.WriteLine($"Status is: {_status}");
    }

    public string ChangePassword(string currentPassword, string newPassword)
    {
      if (currentPassword.Equals(_password))
      {
        _password = newPassword;
        return "Password has been updated.";
      }
      return "Incorrect Password";
    }
  }

  enum Status { Locked=1, Closed, Open }
  enum Options { Open=1, Lock, Close, Unlock, Change_Password }
}