using FluentMigrator;

namespace RandomFilmServer.Migrator.Migrations
{
    [Migration(202111101945)]
    public class InitMigration : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("films")
                .WithColumn("id").AsGuid().PrimaryKey()
                .WithColumn("name").AsString().Indexed().NotNullable()
                .WithColumn("title").AsString().Nullable()
                .WithColumn("duration").AsTime().NotNullable()
                .WithColumn("year").AsDate().NotNullable()
                .WithColumn("director").AsString()
                .WithColumn("url_trailer").AsString();

            Create.Table("genres")
                .WithColumn("id").AsGuid().PrimaryKey()
                .WithColumn("name").AsString().Indexed();

            Create.Table("filmgenres")
                .WithColumn("id").AsGuid().PrimaryKey()
                .WithColumn("film_id").AsGuid().ForeignKey("fk_filmgenres_films", "films", "id")
                .WithColumn("genre_id").AsGuid().ForeignKey("fk_filmgenres_genres", "genres", "id");
        }
    }
}