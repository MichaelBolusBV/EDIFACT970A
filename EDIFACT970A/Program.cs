// See https://aka.ms/new-console-template for more information
using EDIFACT970A;
using System.Xml;

Console.WriteLine("EDIFACT 970A Read Orders!");

string ediString = @"UNA:+.? '
UNB+UNOD:3+TST1WORKHUMANCO:ZZZ+BE2BUK:ZZ+231017:0952+100000013'
UNH+1013+ORDERS:D:97A:UN'
BGM+220+456456456+9'
DTM+4:20231017:102'
RFF+IA:UKIMERBE2B'
RFF+CR:XX-9R3D8-QP6QR-T8DHM-BJNK2'
RFF+SD:011'
NAD+BT+US_INC::92++Accounts Payable+Globoforce Inc d/b/a Workhuman:200 Crossing Blvd:Suite 500+Framingham+MA+01702+US'
NAD+ST+++Jane Doe+17 BRAGG RD+FOXBORO+MA+02035+US'
RFF+VA:4564651'
CTA+IC'
COM+6125554848:TE'
COM+janedoe@yahoo.com:EM'
CUX+1:USD:9'
SCC+1+SC'
LIN+1++GWP-CRPS008:VN'
IMD+F+8+:::Sony PS4 Pro 1TB'
QTY+21:1:EA'
PRI+AAB:359.99'
UNS+S'
MOA+128:359.99'
CNT+2:1'
UNT+22+1013'
UNZ+1+100000013'";

EDIMessage msg = new EDIMessage(ediString);

Console.ReadLine();
