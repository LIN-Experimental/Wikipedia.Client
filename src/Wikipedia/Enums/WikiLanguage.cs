﻿namespace Wikipedia.Enums;

/// <summary>
///     Todos los lenguajes soportados por Wikipedia.
///     Source: http://meta.wikimedia.org/wiki/List_of_Wikipedias
/// </summary>
public enum WikiLanguage
{
    NotSet = 0,
    [StringValue("en")] English,
    [StringValue("de")] German,
    [StringValue("fr")] French,
    [StringValue("nl")] Dutch,
    [StringValue("it")] Italian,
    [StringValue("pl")] Polish,
    [StringValue("es")] Spanish,
    [StringValue("ru")] Russian,
    [StringValue("ja")] Japanese,
    [StringValue("pt")] Portuguese,
    [StringValue("zh")] Chinese,
    [StringValue("sv")] Swedish,
    [StringValue("vi")] Vietnamese,
    [StringValue("uk")] Ukrainian,
    [StringValue("ca")] Catalan,
    [StringValue("no")] NorwegianBokmål,
    [StringValue("fi")] Finnish,
    [StringValue("cs")] Czech,
    [StringValue("hu")] Hungarian,
    [StringValue("fa")] Persian,
    [StringValue("ko")] Korean,
    [StringValue("id")] Indonesian,
    [StringValue("tr")] Turkish,
    [StringValue("ar")] Arabic,
    [StringValue("ro")] Romanian,
    [StringValue("sk")] Slovak,
    [StringValue("eo")] Esperanto,
    [StringValue("da")] Danish,
    [StringValue("sr")] Serbian,
    [StringValue("lt")] Lithuanian,
    [StringValue("ms")] Malay,
    [StringValue("kk")] Kazakh,
    [StringValue("he")] Hebrew,
    [StringValue("eu")] Basque,
    [StringValue("bg")] Bulgarian,
    [StringValue("sl")] Slovenian,
    [StringValue("vo")] Volapük,
    [StringValue("hr")] Croatian,
    [StringValue("war")] WarayWaray,
    [StringValue("hi")] Hindi,
    [StringValue("et")] Estonian,
    [StringValue("az")] Azerbaijani,
    [StringValue("gl")] Galician,
    [StringValue("nn")] NorwegianNynorsk,
    [StringValue("simple")] SimpleEnglish,
    [StringValue("la")] Latin,
    [StringValue("el")] Greek,
    [StringValue("th")] Thai,
    [StringValue("new")] NewarNepalBhasa,
    [StringValue("sh")] SerboCroatian,
    [StringValue("roa-rup")] Aromanian,
    [StringValue("oc")] Occitan,
    [StringValue("ka")] Georgian,
    [StringValue("mk")] Macedonian,
    [StringValue("tl")] Tagalog,
    [StringValue("ht")] Haitian,
    [StringValue("pms")] Piedmontese,
    [StringValue("te(")] Telugu,
    [StringValue("ta")] Tamil,
    [StringValue("be-x-old")] BelarusianTaraškievica,
    [StringValue("be(")] Belarusian,
    [StringValue("br")] Breton,
    [StringValue("ceb")] Cebuano,
    [StringValue("lv")] Latvian,
    [StringValue("sq")] Albanian,
    [StringValue("jv")] Javanese,
    [StringValue("mg")] Malagasy,
    [StringValue("cy")] Welsh,
    [StringValue("mr")] Marathi,
    [StringValue("lb")] Luxembourgish,
    [StringValue("is")] Icelandic,
    [StringValue("bs")] Bosnian,
    [StringValue("yo")] Yoruba,
    [StringValue("an")] Aragonese,
    [StringValue("lmo")] Lombard,
    [StringValue("hy")] Armenian,
    [StringValue("fy")] WestFrisian,
    [StringValue("bpy")] BishnupriyaManipuri,
    [StringValue("ml")] Malayalam,
    [StringValue("pnb")] WesternPanjabi,
    [StringValue("sw")] Swahili,
    [StringValue("bn")] Bengali,
    [StringValue("io")] Ido,
    [StringValue("af")] Afrikaans,
    [StringValue("gu")] Gujarati,
    [StringValue("uz")] Uzbek,
    [StringValue("zh-yue")] Cantonese,
    [StringValue("ne")] Nepali,
    [StringValue("nds")] LowSaxon,
    [StringValue("ur")] Urdu,
    [StringValue("ku")] Kurdish,
    [StringValue("ast")] Asturian,
    [StringValue("scn")] Sicilian,
    [StringValue("su")] Sundanese,
    [StringValue("qu")] Quechua,
    [StringValue("diq")] Zazaki,
    [StringValue("ba")] Bashkir,
    [StringValue("tt")] Tatar,
    [StringValue("my")] Burmese,
    [StringValue("ga")] Irish,
    [StringValue("cv")] Chuvash,
    [StringValue("ia")] Interlingua,
    [StringValue("nap")] Neapolitan,
    [StringValue("bat-smg")] Samogitian,
    [StringValue("map-bms")] Banyumasan,
    [StringValue("wa")] Walloon,
    [StringValue("als")] Alemannic,
    [StringValue("am")] Amharic,
    [StringValue("kn")] Kannada,
    [StringValue("gd")] ScottishGaelic,
    [StringValue("bug")] Buginese,
    [StringValue("tg")] Tajik,
    [StringValue("zh-min-nan")] MinNan,
    [StringValue("yi")] Yiddish,
    [StringValue("sco")] Scots,
    [StringValue("vec")] Venetian,
    [StringValue("hif")] FijiHindi,
    [StringValue("roa-tara")] Tarantino,
    [StringValue("arz")] EgyptianArabic,
    [StringValue("os")] Ossetian,
    [StringValue("mzn")] Mazandarani,
    [StringValue("nah")] Nahuatl,
    [StringValue("ky")] Kirghiz,
    [StringValue("sah")] Sakha,
    [StringValue("mn")] Mongolian,
    [StringValue("sa")] Sanskrit,
    [StringValue("pam")] Kapampangan,
    [StringValue("hsb")] UpperSorbian,
    [StringValue("ckb")] Sorani,
    [StringValue("li")] Limburgian,
    [StringValue("mi")] Maori,
    [StringValue("si")] Sinhalese,
    [StringValue("co")] Corsican,
    [StringValue("gan")] Gan,
    [StringValue("glk")] Gilaki,
    [StringValue("bo")] Tibetan,
    [StringValue("fo")] Faroese,
    [StringValue("bar")] Bavarian,
    [StringValue("bcl")] CentralBicolano,
    [StringValue("ilo")] Ilokano,
    [StringValue("mrj")] HillMari,
    [StringValue("se")] NorthernSami,
    [StringValue("fiu-vro")] Võro,
    [StringValue("nds-nl")] DutchLowSaxon,
    [StringValue("tk")] Turkmen,
    [StringValue("vls")] WestFlemish,
    [StringValue("ps")] Pashto,
    [StringValue("gv")] Manx,
    [StringValue("rue")] Rusyn,
    [StringValue("dv")] Divehi,
    [StringValue("nrm")] Norman,
    [StringValue("pag")] Pangasinan,
    [StringValue("pa")] Punjabi,
    [StringValue("koi")] KomiPermyak,
    [StringValue("rm")] Romansh,
    [StringValue("km")] Khmer,
    [StringValue("kv")] Komi,
    [StringValue("xmf")] Mingrelian,
    [StringValue("csb")] Kashubian,
    [StringValue("udm")] Udmurt,
    [StringValue("mhr")] MeadowMari,
    [StringValue("fur")] Friulian,
    [StringValue("mt")] Maltese,
    [StringValue("zea")] Zeelandic,
    [StringValue("wuu")] Wu,
    [StringValue("lad")] Ladino,
    [StringValue("lij")] Ligurian,
    [StringValue("ug")] Uyghur,
    [StringValue("pi")] Pali,
    [StringValue("sc")] Sardinian,
    [StringValue("bh")] Bihari,
    [StringValue("zh-classical")] ClassicalChinese,
    [StringValue("or")] Oriya,
    [StringValue("nov")] Novial,
    [StringValue("ksh")] Ripuarian,
    [StringValue("frr")] NorthFrisian,
    [StringValue("ang")] AngloSaxon,
    [StringValue("so")] Somali,
    [StringValue("kw")] Cornish,
    [StringValue("stq")] SaterlandFrisian,
    [StringValue("nv")] Navajo,
    [StringValue("hak")] Hakka,
    [StringValue("ay")] Aymara,
    [StringValue("frp")] FrancoProvençalArpitan,
    [StringValue("ext")] Extremaduran,
    [StringValue("szl")] Silesian,
    [StringValue("pcd")] Picard,
    [StringValue("gag")] Gagauz,
    [StringValue("ie")] Interlingue,
    [StringValue("ln")] Lingala,
    [StringValue("haw")] Hawaiian,
    [StringValue("xal")] Kalmyk,
    [StringValue("rw")] Kinyarwanda,
    [StringValue("pdc")] PennsylvaniaGerman,
    [StringValue("vep")] Vepsian,
    [StringValue("pfl")] PalatinateGerman,
    [StringValue("krc")] KarachayBalkar,
    [StringValue("eml")] EmilianRomagnol,
    [StringValue("crh")] CrimeanTatar,
    [StringValue("gn")] Guarani,
    [StringValue("ace")] Acehnese,
    [StringValue("to")] Tongan,
    [StringValue("ce")] Chechen,
    [StringValue("kl")] Greenlandic,
    [StringValue("arc")] AssyrianNeoAramaic,
    [StringValue("myv")] Erzya,
    [StringValue("dsb")] LowerSorbian,
    [StringValue("as")] Assamese,
    [StringValue("bjn")] Banjar,
    [StringValue("pap")] Papiamentu,
    [StringValue("tpi")] TokPisin,
    [StringValue("lbe")] Lak,
    [StringValue("mdf")] Moksha,
    [StringValue("wo")] Wolof,
    [StringValue("jbo")] Lojban,
    [StringValue("sn")] Shona,
    [StringValue("kab")] Kabyle,
    [StringValue("av")] Avar,
    [StringValue("cbk-zam")] ZamboangaChavacano,
    [StringValue("ty")] Tahitian,
    [StringValue("srn")] Sranan,
    [StringValue("kbd")] KabardianCircassian,
    [StringValue("lez")] Lezgian,
    [StringValue("lo")] Lao,
    [StringValue("ab")] Abkhazian,
    [StringValue("tet")] Tetum,
    [StringValue("mwl")] Mirandese,
    [StringValue("ltg")] Latgalian,
    [StringValue("na")] Nauruan,
    [StringValue("ig")] Igbo,
    [StringValue("kg")] Kongo,
    [StringValue("za")] Zhuang,
    [StringValue("kaa")] Karakalpak,
    [StringValue("nso")] NorthernSotho,
    [StringValue("zu")] Zulu,
    [StringValue("rmy")] Romani,
    [StringValue("cu")] OldChurchSlavonic,
    [StringValue("tn")] Tswana,
    [StringValue("chy")] Cheyenne,
    [StringValue("chr")] Cherokee,
    [StringValue("got")] Gothic,
    [StringValue("sm")] Samoan,
    [StringValue("bi")] Bislama,
    [StringValue("mo")] Moldovan,
    [StringValue("iu")] Inuktitut,
    [StringValue("bm")] Bambara,
    [StringValue("pih")] Norfolk,
    [StringValue("ik")] Inupiak,
    [StringValue("ss")] Swati,
    [StringValue("sd")] Sindhi,
    [StringValue("pnt")] Pontic,
    [StringValue("cdo")] MinDong,
    [StringValue("ee")] Ewe,
    [StringValue("ha")] Hausa,
    [StringValue("ti")] Tigrinya,
    [StringValue("bxr")] BuryatRussia,
    [StringValue("ts")] Tsonga,
    [StringValue("om")] Oromo,
    [StringValue("ks")] Kashmiri,
    [StringValue("ki")] Kikuyu,
    [StringValue("ve(")] Venda,
    [StringValue("sg")] Sango,
    [StringValue("rn")] Kirundi,
    [StringValue("cr")] Cree,
    [StringValue("dz")] Dzongkha,
    [StringValue("lg")] Luganda,
    [StringValue("ak")] Akan,
    [StringValue("ff")] Fula,
    [StringValue("tum")] Tumbuka,
    [StringValue("fj")] Fijian,
    [StringValue("st")] Sesotho,
    [StringValue("tw")] Twi,
    [StringValue("xh")] Xhosa,
    [StringValue("ch")] Chamorro,
    [StringValue("ny")] Chichewa,
    [StringValue("ng")] Ndonga,
    [StringValue("ii")] SichuanYi,
    [StringValue("cho")] Choctaw,
    [StringValue("mh")] Marshallese,
    [StringValue("kj")] Kuanyama,
    [StringValue("ho")] HiriMotu,
    [StringValue("mus")] Muscogee,
    [StringValue("kr")] Kanuri,
    [StringValue("hz")] Herero
}