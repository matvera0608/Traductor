using System;

namespace 不同的语言数据库
{
    //Esta es mi clase llamada palabra
    // con un atributo llamado nombre para referirse cuando escribo una palabra en el txBox
    //tiene un método llamado translate que contendrá la palabra a traducir
    public class fānyì
    {
        public string Ming_zi { get; set; }
        public string Yǔyán { get; set; }

        //En este método irá todo lo que es la traducción de una palabra. Tiene switch para elegir el idioma
        public String translate(string cí)
        {
            string fānyì_cí = cí;
            switch (Yǔyán)
            {
                case "西语":
                    {
                        fānyì_cí = "Base de datos";
                        break;
                    }
                case "英语":
                    {
                        fānyì_cí = "Database";
                        break;
                    }
                case "葡萄牙语":
                    {
                        fānyì_cí = "Banco de dados";
                        break;
                    }
                case "法语":
                    {
                        fānyì_cí = "Base de Données";
                        break;
                    }
                case "意大利语":
                    {
                        fānyì_cí = "Base di dati";
                        break;
                    }
                case "德语":
                    {
                        fānyì_cí = "Datenbank";
                        break;
                    }
                case "俄语":
                    {
                        fānyì_cí = "база данных";
                        break;
                    }
                case "汉语":
                    {
                        fānyì_cí = "数据库";
                        break;
                    }
                case "日语":
                    {
                        fānyì_cí = "データベース";
                        break;
                    }
                case "韩语":
                    {
                        fānyì_cí = "데이터베이스";
                        break;
                    }
            }
            return fānyì_cí;
        }
    }
}
