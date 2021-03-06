using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;


namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client
                .TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                    gamer.IdentityNumber, gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.BirthYear))).Result
                .Body.TCKimlikNoDogrulaResult;
        }
    }
}
