namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopluateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql( "INSERT INTO Genres(Id, Name) VALUES(1, 'Rock')" );
            Sql( "INSERT INTO Genres(Id, Name) VALUES(2, 'Country')" );
            Sql( "INSERT INTO Genres(Id, Name) VALUES(3, 'Rap')" );
            Sql( "INSERT INTO Genres(Id, Name) VALUES(4, 'Jazz')" );
            Sql( "INSERT INTO Genres(Id, Name) VALUES(5, 'Blues')" );
        }

        public override void Down()
        {
            Sql( "DELETE FROM Genres WHERE Id IN (1, 2, 3, 4, 5)" );
        }
    }
}
