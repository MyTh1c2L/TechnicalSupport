using System.Collections.Generic;

namespace TechnicalSupport
{
    public class SettingsJSON
    {
        public DB DataBase { get; set; }
    }

    public class DB
    {
        public problem Problem { get; set; }
        public tarif Tarif { get; set; }
        public communication Communication { get; set; }
    }

    public class problem
    {
        public List<string> nameProblem { get; set; }
        public List<List<string>> ListReshProblem { get; set; }
    }

    public class tarif
    {
        public List<string> nameTarif { get; set; }
        public List<List<string>> ListTextTarif { get; set; }
    }

    public class communication
    {
        public List<string> phone { get; set; }
        public List<string> email { get; set; }
    }

}
