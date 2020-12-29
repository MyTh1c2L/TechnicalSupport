using System.Collections.Generic;

namespace TechnicalSupport
{
    class SettingsJSON
    {
        public DB DataBase { get; set; }
    }

    class DB
    {
        public problem Problem { get; set; }
        public tarif Tarif { get; set; }
        public communication Communication { get; set; }
    }

    class problem
    {
        public List<string> nameProblem { get; set; }
        public List<List<string>> ListReshProblem { get; set; }
    }

    class tarif
    {
        public List<string> nameTarif { get; set; }
        public List<List<string>> ListTextTarif { get; set; }
    }

    class communication
    {
        public List<string> phone { get; set; }
        public List<string> email { get; set; }
    }

}
