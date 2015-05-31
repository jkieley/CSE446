﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface INumberGuess
{

    [WebGet(UriTemplate = "/secret?lower={lower}&upper={upper}", ResponseFormat = WebMessageFormat.Xml)]
    int SecretNumber(int lower, int upper);

    [WebGet(UriTemplate = "/check?userNum={userNum}&SecretNum={SecretNum}", ResponseFormat = WebMessageFormat.Xml)]
    string checkNumber(int userNum, int SecretNum);
}
