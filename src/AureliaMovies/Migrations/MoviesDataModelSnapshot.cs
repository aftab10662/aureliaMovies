using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using AureliaMovies.Data;
using Microsoft.Data.Entity.SqlServer.Metadata;

namespace AureliaMovies.Migrations
{
    [DbContext(typeof(MoviesData))]
    partial class MoviesDataModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Annotation("ProductVersion", "7.0.0-beta7-15540")
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerIdentityStrategy.IdentityColumn);

            modelBuilder.Entity("AureliaMovies.Model.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ReleaseYear");

                    b.Property<string>("Title");

                    b.Key("Id");
                });
        }
    }
}
