using System;

namespace The_Password_Validator
{
  internal class PasswordValidator
  {
    private readonly string password;

    public PasswordValidator(string password)
    {
      this.password = password;
    }

    public Boolean Validator()
    {
      Boolean capitalLetter = false;
      Boolean lowerCaseLetter = false;
      Boolean numberChar = false;
      Boolean noCapitalT = true;
      Boolean noAmpersand = true;

      if (this.password.Length > 13 || this.password.Length < 6)
      {
        return false;
      }

      foreach (char letter in this.password)
      {
        if (letter.Equals('&'))
        {
          noAmpersand = false;
          break;
        }
        if (letter.Equals('T'))
        {
          noCapitalT = false;
          break;
        }
        if (char.IsUpper(letter))
        {
          capitalLetter = true;
        }
        if (char.IsLower(letter))
        {
          lowerCaseLetter = true;
        }
        if (char.IsNumber(letter))
        {
          numberChar = true;
        }
      }

      if (
          capitalLetter == true &&
          lowerCaseLetter == true &&
          numberChar == true &&
          noCapitalT == true &&
          noAmpersand == true
         )
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
