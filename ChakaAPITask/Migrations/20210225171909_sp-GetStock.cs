using Microsoft.EntityFrameworkCore.Migrations;

namespace ChakaAPITask.Migrations
{
    public partial class spGetStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"CREATE PROCEDURE [dbo].[GetStock]
                    @UserId varchar(50),
                    @MerchantId varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    SELECT * FROM Stocks WHERE UserId like @UserId +'%'
                                         AND   MerchantId like @MerchantId +'%'
                END";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
