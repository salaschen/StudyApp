using SQLite;
namespace Study.Models {

    [Table("Category")]
    public class Category {
        [PrimaryKey]
        public Guid Id { get; set; }
        [MaxLength(250), Unique]
        public string Name { get; set; }

        public Category() {
            Id = Guid.NewGuid();
        }

        public Category(string name) {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}