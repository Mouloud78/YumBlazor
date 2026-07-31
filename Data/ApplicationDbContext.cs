using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace YumBlazor.Data
{
    /*
     * Connexion entre l'application et la base de données
     */
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        /*
         * Permet de créer la table dans la base de données
         */
        public DbSet<Category> Category { get; set; }

        /*
         * Appelée par ENtity Framework lors de la construction de la base de données, elle permet de
         *      - configurer les entités;
         *      - défini les relations et contraintes;
         *      - ajouter les données initiales avec (HasData) qui réalise un seeding de la BD (insertion)
         */
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1, 
                    Name="Appetizer"
                },
                new Category
                {
                    Id= 2,
                    Name= "Entree"
                },
                new Category
                {
                    Id= 3,
                    Name= "Dessert"
                }
                );
        }
    }
}
