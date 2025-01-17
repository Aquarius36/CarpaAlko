﻿using System;
using System.IO;
using System.Net;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Craxs_Rat
{
	// Token: 0x020000CF RID: 207
	public class GClass4
	{
		// Token: 0x06000F8B RID: 3979 RVA: 0x000A37E0 File Offset: 0x000A19E0
		public GClass4(MemoryStream memoryStream_0)
		{
			this.strings_0 = new string[]
			{
				"n/a",
				"Asia/Pacific Region",
				"Europe",
				"Andorra",
				"United Arab Emirates",
				"Afghanistan",
				"Antigua and Barbuda",
				"Anguilla",
				"Albania",
				"Armenia",
				"Netherlands Antilles",
				"Angola",
				"Antarctica",
				"Argentina",
				"American Samoa",
				"Austria",
				"Australia",
				"Aruba",
				"Azerbaijan",
				"Bosnia and Herzegovina",
				"Barbados",
				"Bangladesh",
				"Belgium",
				"Burkina Faso",
				"Bulgaria",
				"Bahrain",
				"Burundi",
				"Benin",
				"Bermuda",
				"Brunei Darussalam",
				"Bolivia",
				"Brazil",
				"Bahamas",
				"Bhutan",
				"Bouvet Island",
				"Botswana",
				"Belarus",
				"Belize",
				"Canada",
				"Cocos (Keeling) Islands",
				"Congo, The Democratic Republic of the",
				"Central African Republic",
				"Congo",
				"Switzerland",
				"Cote D'Ivoire",
				"Cook Islands",
				"Chile",
				"Cameroon",
				"China",
				"Colombia",
				"Costa Rica",
				"Cuba",
				"Cape Verde",
				"Christmas Island",
				"Cyprus",
				"Czech Republic",
				"Germany",
				"Djibouti",
				"Denmark",
				"Dominica",
				"Dominican Republic",
				"Algeria",
				"Ecuador",
				"Estonia",
				"Egypt",
				"Western Sahara",
				"Eritrea",
				"Spain",
				"Ethiopia",
				"Finland",
				"Fiji",
				"Falkland Islands (Malvinas)",
				"Micronesia, Federated States of",
				"Faroe Islands",
				"France",
				"France, Metropolitan",
				"Gabon",
				"United Kingdom",
				"Grenada",
				"Georgia",
				"French Guiana",
				"Ghana",
				"Gibraltar",
				"Greenland",
				"Gambia",
				"Guinea",
				"Guadeloupe",
				"Equatorial Guinea",
				"Greece",
				"South Georgia and the South Sandwich Islands",
				"Guatemala",
				"Guam",
				"Guinea-Bissau",
				"Guyana",
				"Hong Kong",
				"Heard Island and McDonald Islands",
				"Honduras",
				"Croatia",
				"Haiti",
				"Hungary",
				"Indonesia",
				"Ireland",
				"Israel",
				"India",
				"British Indian Ocean Territory",
				"Iraq",
				"Iran, Islamic Republic of",
				"Iceland",
				"Italy",
				"Jamaica",
				"Jordan",
				"Japan",
				"Kenya",
				"Kyrgyzstan",
				"Cambodia",
				"Kiribati",
				"Comoros",
				"Saint Kitts and Nevis",
				"Korea, Democratic People's Republic of",
				"Korea, Republic of",
				"Kuwait",
				"Cayman Islands",
				"Kazakstan",
				"Lao People's Democratic Republic",
				"Lebanon",
				"Saint Lucia",
				"Liechtenstein",
				"Sri Lanka",
				"Liberia",
				"Lesotho",
				"Lithuania",
				"Luxembourg",
				"Latvia",
				"Libyan Arab Jamahiriya",
				"Morocco",
				"Monaco",
				"Moldova, Republic of",
				"Madagascar",
				"Marshall Islands",
				"Macedonia, the Former Yugoslav Republic of",
				"Mali",
				"Myanmar",
				"Mongolia",
				"Macao",
				"Northern Mariana Islands",
				"Martinique",
				"Mauritania",
				"Montserrat",
				"Malta",
				"Mauritius",
				"Maldives",
				"Malawi",
				"Mexico",
				"Malaysia",
				"Mozambique",
				"Namibia",
				"New Caledonia",
				"Niger",
				"Norfolk Island",
				"Nigeria",
				"Nicaragua",
				"Netherlands",
				"Norway",
				"Nepal",
				"Nauru",
				"Niue",
				"New Zealand",
				"Oman",
				"Panama",
				"Peru",
				"French Polynesia",
				"Papua New Guinea",
				"Philippines",
				"Pakistan",
				"Poland",
				"Saint Pierre and Miquelon",
				"Pitcairn",
				"Puerto Rico",
				"Palestinian Territory, Occupied",
				"Portugal",
				"Palau",
				"Paraguay",
				"Qatar",
				"Reunion",
				"Romania",
				"Russian Federation",
				"Rwanda",
				"Saudi Arabia",
				"Solomon Islands",
				"Seychelles",
				"Sudan",
				"Sweden",
				"Singapore",
				"Saint Helena",
				"Slovenia",
				"Svalbard and Jan Mayen",
				"Slovakia",
				"Sierra Leone",
				"San Marino",
				"Senegal",
				"Somalia",
				"Suriname",
				"Sao Tome and Principe",
				"El Salvador",
				"Syrian Arab Republic",
				"Swaziland",
				"Turks and Caicos Islands",
				"Chad",
				"French Southern Territories",
				"Togo",
				"Thailand",
				"Tajikistan",
				"Tokelau",
				"Turkmenistan",
				"Tunisia",
				"Tonga",
				"Timor-Leste",
				"Turkey",
				"Trinidad and Tobago",
				"Tuvalu",
				"Taiwan, Province of China",
				"Tanzania, United Republic of",
				"Ukraine",
				"Uganda",
				"United States Minor Outlying Islands",
				"United States",
				"Uruguay",
				"Uzbekistan",
				"Holy See (Vatican City State)",
				"Saint Vincent and the Grenadines",
				"Venezuela",
				"Virgin Islands, British",
				"Virgin Islands, U.S.",
				"Vietnam",
				"Vanuatu",
				"Wallis and Futuna",
				"Samoa",
				"Yemen",
				"Mayotte",
				"Yugoslavia",
				"South Africa",
				"Zambia",
				"Montenegro",
				"Zimbabwe",
				"Anonymous Proxy",
				"Satellite Provider",
				"Other",
				"Aland Islands",
				"Guernsey",
				"Isle of Man",
				"Jersey",
				"Saint Barthelemy",
				"Saint Martin"
			};
			this.strings_1 = new string[]
			{
				"n/a",
				"AP",
				"EU",
				"AD",
				"AE",
				"AF",
				"AG",
				"AI",
				"AL",
				"AM",
				"AN",
				"AO",
				"AQ",
				"AR",
				"AS",
				"AT",
				"AU",
				"AW",
				"AZ",
				"BA",
				"BB",
				"BD",
				"BE",
				"BF",
				"BG",
				"BH",
				"BI",
				"BJ",
				"BM",
				"BN",
				"BO",
				"BR",
				"BS",
				"BT",
				"BV",
				"BW",
				"BY",
				"BZ",
				"CA",
				"CC",
				"CD",
				"CF",
				"CG",
				"CH",
				"CI",
				"CK",
				"CL",
				"CM",
				"CN",
				"CO",
				"CR",
				"CU",
				"CV",
				"CX",
				"CY",
				"CZ",
				"DE",
				"DJ",
				"DK",
				"DM",
				"DO",
				"DZ",
				"EC",
				"EE",
				"EG",
				"EH",
				"ER",
				"ES",
				"ET",
				"FI",
				"FJ",
				"FK",
				"FM",
				"FO",
				"FR",
				"FX",
				"GA",
				"GB",
				"GD",
				"GE",
				"GF",
				"GH",
				"GI",
				"GL",
				"GM",
				"GN",
				"GP",
				"GQ",
				"GR",
				"GS",
				"GT",
				"GU",
				"GW",
				"GY",
				"HK",
				"HM",
				"HN",
				"HR",
				"HT",
				"HU",
				"ID",
				"IE",
				"IL",
				"IN",
				"IO",
				"IQ",
				"IR",
				"IS",
				"IT",
				"JM",
				"JO",
				"JP",
				"KE",
				"KG",
				"KH",
				"KI",
				"KM",
				"KN",
				"KP",
				"KR",
				"KW",
				"KY",
				"KZ",
				"LA",
				"LB",
				"LC",
				"LI",
				"LK",
				"LR",
				"LS",
				"LT",
				"LU",
				"LV",
				"LY",
				"MA",
				"MC",
				"MD",
				"MG",
				"MH",
				"MK",
				"ML",
				"MM",
				"MN",
				"MO",
				"MP",
				"MQ",
				"MR",
				"MS",
				"MT",
				"MU",
				"MV",
				"MW",
				"MX",
				"MY",
				"MZ",
				"NA",
				"NC",
				"NE",
				"NF",
				"NG",
				"NI",
				"NL",
				"NO",
				"NP",
				"NR",
				"NU",
				"NZ",
				"OM",
				"PA",
				"PE",
				"PF",
				"PG",
				"PH",
				"PK",
				"PL",
				"PM",
				"PN",
				"PR",
				"PS",
				"PT",
				"PW",
				"PY",
				"QA",
				"RE",
				"RO",
				"RU",
				"RW",
				"SA",
				"SB",
				"SC",
				"SD",
				"SE",
				"SG",
				"SH",
				"SI",
				"SJ",
				"SK",
				"SL",
				"SM",
				"SN",
				"SO",
				"SR",
				"ST",
				"SV",
				"SY",
				"SZ",
				"TC",
				"TD",
				"TF",
				"TG",
				"TH",
				"TJ",
				"TK",
				"TM",
				"TN",
				"TO",
				"TL",
				"TR",
				"TT",
				"TV",
				"TW",
				"TZ",
				"UA",
				"UG",
				"UM",
				"US",
				"UY",
				"UZ",
				"VA",
				"VC",
				"VE",
				"VG",
				"VI",
				"VN",
				"VU",
				"WF",
				"WS",
				"YE",
				"YT",
				"SAU",
				"RS",
				"ZA",
				"ZM",
				"ME",
				"ZW",
				"A1",
				"A2",
				"O1",
				"AX",
				"GG",
				"IM",
				"JE",
				"BL",
				"MF"
			};
			this.strings_2 = new string[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20",
				"21",
				"22",
				"23",
				"24",
				"25",
				"26",
				"27",
				"28",
				"29",
				"30",
				"31",
				"32",
				"33",
				"34",
				"35",
				"36",
				"37",
				"38",
				"39",
				"40",
				"41",
				"42",
				"43",
				"44",
				"45",
				"46",
				"47",
				"48",
				"49",
				"50",
				"51",
				"52",
				"53",
				"54",
				"55",
				"56",
				"57",
				"58",
				"59",
				"60",
				"61",
				"62",
				"63",
				"64",
				"65",
				"66",
				"67",
				"68",
				"69",
				"70",
				"71",
				"72",
				"73",
				"74",
				"75",
				"76",
				"77",
				"78",
				"79",
				"80",
				"81",
				"82",
				"83",
				"84",
				"85",
				"86",
				"87",
				"88",
				"89",
				"90",
				"91",
				"92",
				"93",
				"94",
				"95",
				"96",
				"97",
				"98",
				"99",
				"100",
				"101",
				"102",
				"103",
				"104",
				"105",
				"106",
				"107",
				"108",
				"109",
				"110",
				"111",
				"112",
				"113",
				"114",
				"115",
				"116",
				"117",
				"118",
				"119",
				"120",
				"121",
				"122",
				"123",
				"124",
				"125",
				"126",
				"127",
				"128",
				"129",
				"130",
				"131",
				"132",
				"133",
				"134",
				"135",
				"136",
				"137",
				"138",
				"139",
				"140",
				"141",
				"142",
				"143",
				"144",
				"145",
				"146",
				"147",
				"148",
				"149",
				"150",
				"151",
				"152",
				"153",
				"154",
				"155",
				"156",
				"157",
				"158",
				"159",
				"160",
				"161",
				"162",
				"163",
				"164",
				"165",
				"166",
				"167",
				"168",
				"169",
				"170",
				"171",
				"172",
				"173",
				"174",
				"175",
				"176",
				"177",
				"178",
				"179",
				"180",
				"181",
				"182",
				"183",
				"184",
				"185",
				"186",
				"187",
				"188",
				"189",
				"190",
				"191",
				"192",
				"193",
				"194",
				"195",
				"196",
				"197",
				"198",
				"199",
				"200",
				"201",
				"202",
				"203",
				"204",
				"205",
				"206",
				"207",
				"208",
				"209",
				"210",
				"211",
				"212",
				"213",
				"214",
				"215",
				"216",
				"217",
				"218",
				"219",
				"220",
				"221",
				"222",
				"223",
				"224",
				"225",
				"226",
				"227",
				"228",
				"229",
				"230",
				"231",
				"232",
				"233",
				"234",
				"235",
				"236",
				"237",
				"238",
				"239",
				"240",
				"241",
				"242",
				"243",
				"244",
				"245",
				"246",
				"247",
				"248",
				"249",
				"250",
				"251",
				"252",
				"253",
				"254"
			};
			this.memoryStream_0 = memoryStream_0;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000A5748 File Offset: 0x000A3948
		public GClass4(string string_0)
		{
			this.strings_0 = new string[]
			{
				"n/a",
				"Asia/Pacific Region",
				"Europe",
				"Andorra",
				"United Arab Emirates",
				"Afghanistan",
				"Antigua and Barbuda",
				"Anguilla",
				"Albania",
				"Armenia",
				"Netherlands Antilles",
				"Angola",
				"Antarctica",
				"Argentina",
				"American Samoa",
				"Austria",
				"Australia",
				"Aruba",
				"Azerbaijan",
				"Bosnia and Herzegovina",
				"Barbados",
				"Bangladesh",
				"Belgium",
				"Burkina Faso",
				"Bulgaria",
				"Bahrain",
				"Burundi",
				"Benin",
				"Bermuda",
				"Brunei Darussalam",
				"Bolivia",
				"Brazil",
				"Bahamas",
				"Bhutan",
				"Bouvet Island",
				"Botswana",
				"Belarus",
				"Belize",
				"Canada",
				"Cocos (Keeling) Islands",
				"Congo, The Democratic Republic of the",
				"Central African Republic",
				"Congo",
				"Switzerland",
				"Cote D'Ivoire",
				"Cook Islands",
				"Chile",
				"Cameroon",
				"China",
				"Colombia",
				"Costa Rica",
				"Cuba",
				"Cape Verde",
				"Christmas Island",
				"Cyprus",
				"Czech Republic",
				"Germany",
				"Djibouti",
				"Denmark",
				"Dominica",
				"Dominican Republic",
				"Algeria",
				"Ecuador",
				"Estonia",
				"Egypt",
				"Western Sahara",
				"Eritrea",
				"Spain",
				"Ethiopia",
				"Finland",
				"Fiji",
				"Falkland Islands (Malvinas)",
				"Micronesia, Federated States of",
				"Faroe Islands",
				"France",
				"France, Metropolitan",
				"Gabon",
				"United Kingdom",
				"Grenada",
				"Georgia",
				"French Guiana",
				"Ghana",
				"Gibraltar",
				"Greenland",
				"Gambia",
				"Guinea",
				"Guadeloupe",
				"Equatorial Guinea",
				"Greece",
				"South Georgia and the South Sandwich Islands",
				"Guatemala",
				"Guam",
				"Guinea-Bissau",
				"Guyana",
				"Hong Kong",
				"Heard Island and McDonald Islands",
				"Honduras",
				"Croatia",
				"Haiti",
				"Hungary",
				"Indonesia",
				"Ireland",
				"Israel",
				"India",
				"British Indian Ocean Territory",
				"Iraq",
				"Iran, Islamic Republic of",
				"Iceland",
				"Italy",
				"Jamaica",
				"Jordan",
				"Japan",
				"Kenya",
				"Kyrgyzstan",
				"Cambodia",
				"Kiribati",
				"Comoros",
				"Saint Kitts and Nevis",
				"Korea, Democratic People's Republic of",
				"Korea, Republic of",
				"Kuwait",
				"Cayman Islands",
				"Kazakstan",
				"Lao People's Democratic Republic",
				"Lebanon",
				"Saint Lucia",
				"Liechtenstein",
				"Sri Lanka",
				"Liberia",
				"Lesotho",
				"Lithuania",
				"Luxembourg",
				"Latvia",
				"Libyan Arab Jamahiriya",
				"Morocco",
				"Monaco",
				"Moldova, Republic of",
				"Madagascar",
				"Marshall Islands",
				"Macedonia, the Former Yugoslav Republic of",
				"Mali",
				"Myanmar",
				"Mongolia",
				"Macao",
				"Northern Mariana Islands",
				"Martinique",
				"Mauritania",
				"Montserrat",
				"Malta",
				"Mauritius",
				"Maldives",
				"Malawi",
				"Mexico",
				"Malaysia",
				"Mozambique",
				"Namibia",
				"New Caledonia",
				"Niger",
				"Norfolk Island",
				"Nigeria",
				"Nicaragua",
				"Netherlands",
				"Norway",
				"Nepal",
				"Nauru",
				"Niue",
				"New Zealand",
				"Oman",
				"Panama",
				"Peru",
				"French Polynesia",
				"Papua New Guinea",
				"Philippines",
				"Pakistan",
				"Poland",
				"Saint Pierre and Miquelon",
				"Pitcairn",
				"Puerto Rico",
				"Palestinian Territory, Occupied",
				"Portugal",
				"Palau",
				"Paraguay",
				"Qatar",
				"Reunion",
				"Romania",
				"Russian Federation",
				"Rwanda",
				"Saudi Arabia",
				"Solomon Islands",
				"Seychelles",
				"Sudan",
				"Sweden",
				"Singapore",
				"Saint Helena",
				"Slovenia",
				"Svalbard and Jan Mayen",
				"Slovakia",
				"Sierra Leone",
				"San Marino",
				"Senegal",
				"Somalia",
				"Suriname",
				"Sao Tome and Principe",
				"El Salvador",
				"Syrian Arab Republic",
				"Swaziland",
				"Turks and Caicos Islands",
				"Chad",
				"French Southern Territories",
				"Togo",
				"Thailand",
				"Tajikistan",
				"Tokelau",
				"Turkmenistan",
				"Tunisia",
				"Tonga",
				"Timor-Leste",
				"Turkey",
				"Trinidad and Tobago",
				"Tuvalu",
				"Taiwan, Province of China",
				"Tanzania, United Republic of",
				"Ukraine",
				"Uganda",
				"United States Minor Outlying Islands",
				"United States",
				"Uruguay",
				"Uzbekistan",
				"Holy See (Vatican City State)",
				"Saint Vincent and the Grenadines",
				"Venezuela",
				"Virgin Islands, British",
				"Virgin Islands, U.S.",
				"Vietnam",
				"Vanuatu",
				"Wallis and Futuna",
				"Samoa",
				"Yemen",
				"Mayotte",
				"Yugoslavia",
				"South Africa",
				"Zambia",
				"Montenegro",
				"Zimbabwe",
				"Anonymous Proxy",
				"Satellite Provider",
				"Other",
				"Aland Islands",
				"Guernsey",
				"Isle of Man",
				"Jersey",
				"Saint Barthelemy",
				"Saint Martin"
			};
			this.strings_1 = new string[]
			{
				"n/a",
				"AP",
				"EU",
				"AD",
				"AE",
				"AF",
				"AG",
				"AI",
				"AL",
				"AM",
				"AN",
				"AO",
				"AQ",
				"AR",
				"AS",
				"AT",
				"AU",
				"AW",
				"AZ",
				"BA",
				"BB",
				"BD",
				"BE",
				"BF",
				"BG",
				"BH",
				"BI",
				"BJ",
				"BM",
				"BN",
				"BO",
				"BR",
				"BS",
				"BT",
				"BV",
				"BW",
				"BY",
				"BZ",
				"CA",
				"CC",
				"CD",
				"CF",
				"CG",
				"CH",
				"CI",
				"CK",
				"CL",
				"CM",
				"CN",
				"CO",
				"CR",
				"CU",
				"CV",
				"CX",
				"CY",
				"CZ",
				"DE",
				"DJ",
				"DK",
				"DM",
				"DO",
				"DZ",
				"EC",
				"EE",
				"EG",
				"EH",
				"ER",
				"ES",
				"ET",
				"FI",
				"FJ",
				"FK",
				"FM",
				"FO",
				"FR",
				"FX",
				"GA",
				"GB",
				"GD",
				"GE",
				"GF",
				"GH",
				"GI",
				"GL",
				"GM",
				"GN",
				"GP",
				"GQ",
				"GR",
				"GS",
				"GT",
				"GU",
				"GW",
				"GY",
				"HK",
				"HM",
				"HN",
				"HR",
				"HT",
				"HU",
				"ID",
				"IE",
				"IL",
				"IN",
				"IO",
				"IQ",
				"IR",
				"IS",
				"IT",
				"JM",
				"JO",
				"JP",
				"KE",
				"KG",
				"KH",
				"KI",
				"KM",
				"KN",
				"KP",
				"KR",
				"KW",
				"KY",
				"KZ",
				"LA",
				"LB",
				"LC",
				"LI",
				"LK",
				"LR",
				"LS",
				"LT",
				"LU",
				"LV",
				"LY",
				"MA",
				"MC",
				"MD",
				"MG",
				"MH",
				"MK",
				"ML",
				"MM",
				"MN",
				"MO",
				"MP",
				"MQ",
				"MR",
				"MS",
				"MT",
				"MU",
				"MV",
				"MW",
				"MX",
				"MY",
				"MZ",
				"NA",
				"NC",
				"NE",
				"NF",
				"NG",
				"NI",
				"NL",
				"NO",
				"NP",
				"NR",
				"NU",
				"NZ",
				"OM",
				"PA",
				"PE",
				"PF",
				"PG",
				"PH",
				"PK",
				"PL",
				"PM",
				"PN",
				"PR",
				"PS",
				"PT",
				"PW",
				"PY",
				"QA",
				"RE",
				"RO",
				"RU",
				"RW",
				"SA",
				"SB",
				"SC",
				"SD",
				"SE",
				"SG",
				"SH",
				"SI",
				"SJ",
				"SK",
				"SL",
				"SM",
				"SN",
				"SO",
				"SR",
				"ST",
				"SV",
				"SY",
				"SZ",
				"TC",
				"TD",
				"TF",
				"TG",
				"TH",
				"TJ",
				"TK",
				"TM",
				"TN",
				"TO",
				"TL",
				"TR",
				"TT",
				"TV",
				"TW",
				"TZ",
				"UA",
				"UG",
				"UM",
				"US",
				"UY",
				"UZ",
				"VA",
				"VC",
				"VE",
				"VG",
				"VI",
				"VN",
				"VU",
				"WF",
				"WS",
				"YE",
				"YT",
				"SAU",
				"RS",
				"ZA",
				"ZM",
				"ME",
				"ZW",
				"A1",
				"A2",
				"O1",
				"AX",
				"GG",
				"IM",
				"JE",
				"BL",
				"MF"
			};
			this.strings_2 = new string[]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20",
				"21",
				"22",
				"23",
				"24",
				"25",
				"26",
				"27",
				"28",
				"29",
				"30",
				"31",
				"32",
				"33",
				"34",
				"35",
				"36",
				"37",
				"38",
				"39",
				"40",
				"41",
				"42",
				"43",
				"44",
				"45",
				"46",
				"47",
				"48",
				"49",
				"50",
				"51",
				"52",
				"53",
				"54",
				"55",
				"56",
				"57",
				"58",
				"59",
				"60",
				"61",
				"62",
				"63",
				"64",
				"65",
				"66",
				"67",
				"68",
				"69",
				"70",
				"71",
				"72",
				"73",
				"74",
				"75",
				"76",
				"77",
				"78",
				"79",
				"80",
				"81",
				"82",
				"83",
				"84",
				"85",
				"86",
				"87",
				"88",
				"89",
				"90",
				"91",
				"92",
				"93",
				"94",
				"95",
				"96",
				"97",
				"98",
				"99",
				"100",
				"101",
				"102",
				"103",
				"104",
				"105",
				"106",
				"107",
				"108",
				"109",
				"110",
				"111",
				"112",
				"113",
				"114",
				"115",
				"116",
				"117",
				"118",
				"119",
				"120",
				"121",
				"122",
				"123",
				"124",
				"125",
				"126",
				"127",
				"128",
				"129",
				"130",
				"131",
				"132",
				"133",
				"134",
				"135",
				"136",
				"137",
				"138",
				"139",
				"140",
				"141",
				"142",
				"143",
				"144",
				"145",
				"146",
				"147",
				"148",
				"149",
				"150",
				"151",
				"152",
				"153",
				"154",
				"155",
				"156",
				"157",
				"158",
				"159",
				"160",
				"161",
				"162",
				"163",
				"164",
				"165",
				"166",
				"167",
				"168",
				"169",
				"170",
				"171",
				"172",
				"173",
				"174",
				"175",
				"176",
				"177",
				"178",
				"179",
				"180",
				"181",
				"182",
				"183",
				"184",
				"185",
				"186",
				"187",
				"188",
				"189",
				"190",
				"191",
				"192",
				"193",
				"194",
				"195",
				"196",
				"197",
				"198",
				"199",
				"200",
				"201",
				"202",
				"203",
				"204",
				"205",
				"206",
				"207",
				"208",
				"209",
				"210",
				"211",
				"212",
				"213",
				"214",
				"215",
				"216",
				"217",
				"218",
				"219",
				"220",
				"221",
				"222",
				"223",
				"224",
				"225",
				"226",
				"227",
				"228",
				"229",
				"230",
				"231",
				"232",
				"233",
				"234",
				"235",
				"236",
				"237",
				"238",
				"239",
				"240",
				"241",
				"242",
				"243",
				"244",
				"245",
				"246",
				"247",
				"248",
				"249",
				"250",
				"251",
				"252",
				"253",
				"254"
			};
			if (File.Exists(string_0))
			{
				FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
				this.memoryStream_0 = new MemoryStream();
				byte[] array = new byte[257];
				while (fileStream.Read(array, 0, array.Length) != 0)
				{
					this.memoryStream_0.Write(array, 0, array.Length);
				}
				fileStream.Close();
			}
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000A76F8 File Offset: 0x000A58F8
		private long method_0(IPAddress ipaddress_0)
		{
			string[] array = Strings.Split(ipaddress_0.ToString(), ".", -1, CompareMethod.Binary);
			long result;
			if (Information.UBound(array, 1) == 3)
			{
				result = checked((long)Math.Round(unchecked(16777216.0 * Conversions.ToDouble(array[0]) + 65536.0 * Conversions.ToDouble(array[1]) + 256.0 * Conversions.ToDouble(array[2]) + Conversions.ToDouble(array[3]))));
			}
			else
			{
				result = 0L;
			}
			return result;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000A777C File Offset: 0x000A597C
		private string method_1(long long_1)
		{
			return string.Concat(new string[]
			{
				Conversions.ToString(Conversion.Int(Convert.ToDouble(new decimal(long_1)) / 16777216.0) % 256.0),
				".",
				Conversions.ToString(Conversion.Int(Convert.ToDouble(new decimal(long_1)) / 65536.0) % 256.0),
				".",
				Conversions.ToString(Conversion.Int(Convert.ToDouble(new decimal(long_1)) / 256.0) % 256.0),
				".",
				Conversions.ToString(Conversion.Int(long_1) % 256L)
			});
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x000A784C File Offset: 0x000A5A4C
		public static MemoryStream smethod_0(string string_0)
		{
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			MemoryStream memoryStream = new MemoryStream();
			byte[] array = new byte[257];
			while (fileStream.Read(array, 0, array.Length) != 0)
			{
				memoryStream.Write(array, 0, array.Length);
			}
			fileStream.Close();
			return memoryStream;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x000A78A0 File Offset: 0x000A5AA0
		public string method_2(IPAddress ipaddress_0)
		{
			return this.strings_1[checked((int)this.method_10(0L, this.method_0(ipaddress_0), 31))];
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x000A78D0 File Offset: 0x000A5AD0
		public string method_3(IPAddress ipaddress_0)
		{
			return this.strings_2[checked((int)this.method_10(0L, this.method_0(ipaddress_0), 31))];
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000A7900 File Offset: 0x000A5B00
		public string method_4(string string_0)
		{
			IPAddress ipaddress_;
			try
			{
				ipaddress_ = IPAddress.Parse(string_0);
			}
			catch (FormatException ex)
			{
				return "n/a";
			}
			return this.method_3(ipaddress_);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000A7958 File Offset: 0x000A5B58
		public string method_5(string string_0)
		{
			IPAddress ipaddress_;
			try
			{
				ipaddress_ = IPAddress.Parse(string_0);
			}
			catch (FormatException ex)
			{
				return "n/a";
			}
			return this.method_2(ipaddress_);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000A79A4 File Offset: 0x000A5BA4
		public string method_6(IPAddress ipaddress_0)
		{
			return this.strings_0[checked((int)this.method_10(0L, this.method_0(ipaddress_0), 31))];
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000A79D4 File Offset: 0x000A5BD4
		public string method_7(string string_0)
		{
			IPAddress ipaddress_;
			try
			{
				ipaddress_ = IPAddress.Parse(string_0);
			}
			catch (FormatException ex)
			{
				return "n/a";
			}
			return this.method_6(ipaddress_);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000A7A20 File Offset: 0x000A5C20
		private long method_8(long long_1, int int_0)
		{
			long num = long_1;
			checked
			{
				for (int i = 1; i <= int_0; i++)
				{
					num *= 2L;
				}
				return num;
			}
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x000A7A50 File Offset: 0x000A5C50
		private long method_9(long long_1, int int_0)
		{
			long num = long_1;
			checked
			{
				for (int i = 1; i <= int_0; i++)
				{
					num = (long)Math.Round((double)num / 2.0);
				}
				return num;
			}
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000A7A84 File Offset: 0x000A5C84
		private long method_10(long long_1, long long_2, int int_0)
		{
			byte[] array = new byte[7];
			long[] array2 = new long[3];
			if (int_0 == 0)
			{
			}
			checked
			{
				try
				{
					this.memoryStream_0.Seek(6L * long_1, SeekOrigin.Begin);
					this.memoryStream_0.Read(array, 0, 6);
				}
				catch (IOException ex)
				{
				}
				int num = 0;
				do
				{
					array2[num] = 0L;
					int num2 = 0;
					do
					{
						int num3 = (int)array[num * 3 + num2];
						if (num3 < 0)
						{
							num3 += 256;
						}
						long[] array3 = array2;
						int num4 = num;
						ref long ptr = ref array3[num4];
						array3[num4] = ptr + this.method_8(unchecked((long)num3), num2 * 8);
						num2++;
					}
					while (num2 <= 2);
					num++;
				}
				while (num <= 1);
				long result;
				if ((long_2 & this.method_8(1L, int_0)) <= 0L)
				{
					if (array2[0] < GClass4.long_0)
					{
						result = this.method_10(array2[0], long_2, int_0 - 1);
					}
					else
					{
						result = array2[0] - GClass4.long_0;
					}
				}
				else if (array2[1] < GClass4.long_0)
				{
					result = this.method_10(array2[1], long_2, int_0 - 1);
				}
				else
				{
					result = array2[1] - GClass4.long_0;
				}
				return result;
			}
		}

		// Token: 0x04000885 RID: 2181
		public MemoryStream memoryStream_0;

		// Token: 0x04000886 RID: 2182
		private static long long_0 = 16776960L;

		// Token: 0x04000887 RID: 2183
		public string[] strings_0;

		// Token: 0x04000888 RID: 2184
		public string[] strings_1;

		// Token: 0x04000889 RID: 2185
		public string[] strings_2;
	}
}
