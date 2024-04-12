using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Desktop.Validation.ValidationRules
{
    public class NameValidationRules
    {
        private readonly string _nameToValidate;
        public NameValidationRules(string name)
        {
            _nameToValidate = name;
        }

        public bool IsNameShort => _nameToValidate.Length < 2;
        //Acs-Sánt*
        //Farkasné Sz8bó
        //=> IsOnlyLetter || IsSpaceBetweenName || IsDashBetweenName;
        public bool IsOnlyLetterOrSpaceOrDash
        {
            get
            {
                if (string.IsNullOrEmpty(_nameToValidate))
                    return false;
                for (int i = 0; i < _nameToValidate.Length; i++)
                {
                    if (i == 0 || i == _nameToValidate.Length - 1)
                    {
                        if (!char.IsLetter(_nameToValidate[i]))
                            return false;
                    }
                    else
                    {
                        if (!(char.IsLetter(_nameToValidate[i]) || _nameToValidate[i] == ' ' || _nameToValidate[i] == '-'))
                            return false;
                    }
                }
                return true;
            }
        }


        public bool IsOnlyLetterOrSpace
        {
            get
            {
                if (string.IsNullOrEmpty(_nameToValidate))
                    return false;
                for (int i = 0; i < _nameToValidate.Length; i++)
                {
                    if (i == 0 || i == _nameToValidate.Length - 1)
                    {
                        if (!char.IsLetter(_nameToValidate[i]))
                            return false;
                    }
                    else
                    {
                        if (!(char.IsLetter(_nameToValidate[i]) || _nameToValidate[i] == ' '))
                            return false;
                    }
                }
                return true;
            }
        }

        public bool IsOnlyLetter
        {
            get
            {
                if (!_nameToValidate.Any())
                    return false;
                foreach (char c in _nameToValidate)
                    if (!char.IsLetter(c))
                        return false;
                return true;
            }
        }
        // !string.IsNullOrEmpty(_nameToValidate) ? _nameToValidate.All(char.IsLetter) : false;
        public bool IsSpaceBetweenName
        {
            get
            {
                if (string.IsNullOrEmpty(_nameToValidate))
                    return false;
                for (int i = 0; i < _nameToValidate.Length; i++)
                {
                    if (i != 0 && i != _nameToValidate.Length - 1)
                        if (_nameToValidate[i] == ' ')
                            return true;
                }
                return false;
            }
        }

        /*string.IsNullOrEmpty(_nameToValidate) ? false :
            _nameToValidate.First() == ' ' || _nameToValidate.EndsWith(" ") ? false :
                _nameToValidate.Any(char.IsWhiteSpace);*/
        /*=> 
        string.IsNullOrEmpty(_nameToValidate) ? false :
            _nameToValidate.First() == ' ' || _nameToValidate.EndsWith(" ") ? false : 
                _nameToValidate.Contains(" ") ? true : false;*/
        public bool IsDashBetweenName => string.IsNullOrEmpty(_nameToValidate) ? false : _nameToValidate.First() == '-' || _nameToValidate.EndsWith("-") ? false : _nameToValidate.Contains("-") ? true : false;

        public bool IsFirstLetterUppercase => string.IsNullOrEmpty(_nameToValidate) ? false : char.IsUpper(_nameToValidate.First());
    }
}

