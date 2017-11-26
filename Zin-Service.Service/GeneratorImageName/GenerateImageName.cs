using System;

namespace Zin_Service.Service.GeneratorImageName
{
    public class GenerateImageName : IGenerateImageName
    {
        public string GenerateName()
        {
            var guid = Guid.NewGuid();
            if (!String.IsNullOrEmpty(guid.ToString()))
            {
                return guid.ToString();
            }
            else
            {
                throw new ApplicationException();
            }
        }
    }
}