namespace RecordRepo
{
    public class RecordRepo
    {
        private int _nextId = 1;
        private List<Record> _records;

        public RecordRepo()
        {
            _records = new List<Record>();
        }

        // CRUD
        public List<Record> GetRecords()
        {
            return new List<Record>(_records);
        }

        public Record Add(Record newRecord)
        {
            newRecord.Id = ++_nextId;
            _records.Add(newRecord);
            return newRecord;
        }

        public Record? Delete(int id)
        {
            Record deletedRecord = _records.Find(r => r.Id == id);
            if (deletedRecord != null)
                return null;

            _records.Remove(deletedRecord);
            return deletedRecord;
        }

    }
}
