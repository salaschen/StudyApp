using SQLite;

namespace Study.Models {

    internal class StudyAppDb {
        private SQLiteAsyncConnection conn;
        private string _dbPath;

        private void Init() {
            if (conn is not null) {
                return;
            }

            conn = new SQLiteAsyncConnection(_dbPath);

            // Create the Category Table.
            conn.CreateTableAsync<Category>();
        }

        public StudyAppDb(string dbPath) {
            _dbPath = dbPath;
            Init();
        }

        public async Task<List<Category>> GetAllCategories() {
            try {
                var result = await conn.Table<Category>().ToListAsync();
                return result;
            } catch (Exception ex) {
                // do nothing
                Console.WriteLine(ex.Message);
            }
            return new List<Category>();
        }
    }
}