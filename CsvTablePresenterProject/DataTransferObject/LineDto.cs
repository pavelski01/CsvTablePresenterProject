using CsvTablePresenterProject.Contract;

namespace CsvTablePresenterProject.DataTransferObject
{
    public class LineDto : INameable
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string ElectronicMail { get; set; }
    }
}
