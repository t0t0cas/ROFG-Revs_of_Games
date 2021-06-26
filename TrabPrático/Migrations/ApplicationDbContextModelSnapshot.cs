﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrabPrático.Data;

namespace TrabPrático.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TrabPrático.Models.Jogos", b =>
                {
                    b.Property<int>("IdJogo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaIdade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Media")
                        .HasColumnType("float");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Nota")
                        .HasColumnType("float");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJogo");

                    b.ToTable("Jogos");

                    b.HasData(
                        new
                        {
                            IdJogo = 1,
                            CategoriaIdade = "3+",
                            DataLancamento = new DateTime(2020, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "FIFA 21 é um videojogo de simulação de futebol desenvolvido e publicado pela Electronic Arts, tendo como estrela da capa o jogador Kylian Mbappé.O jogo foi anunciado em 19 de junho de 2020, sendo, no mesmo ano, oficialmente publicado no dia 9 de outubro. Lançado de acordo com a temporada 2020-2021, o jogo apresenta como grandes novidades as novas mecânicas de simulação no modo carreira, junto com um editor de estádios no modo Ultimate Team.FIFA 21 foi o primeiro título da série de videojogos FIFA, pertencente à EA Sports, a receber uma versão para as consolar da nova geração. Intitulado de Next Level Realism, o upgrade garantiu uma maior velocidade dos menus, menor tempo de loadings, novo relvado, novas faces, atualizações de estádios, atualização da neve, novos detalhes extracampo e melhorias nas texturas.",
                            Imagem = "FIFA21.jpg",
                            Media = 0.0,
                            Nome = "FIFA 21",
                            Nota = 74.0,
                            Tipo = "Desporto, Simulação"
                        },
                        new
                        {
                            IdJogo = 2,
                            CategoriaIdade = "17+",
                            DataLancamento = new DateTime(2020, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Cyberpunk 2077 é um jogo eletrónico de RPG de ação desenvolvido e publicado pela CD Projekt. Lançado a 10 de dezembro de 2020 para Google Stadia, Microsoft Windows, PlayStation 4 e Xbox One, e previsto para 2021 para PlayStation 5 e Xbox Series X / S, sendo que nesses já está disponível via retrocompatibilidade.A história do jogo é ambientada em Night City, um mundo aberto com seis regiões distintas situado no universo da franquia Cyberpunk.Ele é jogado a partir de uma perspectiva em primeira pessoa, com os jogadores a controlar um mercenário personalizável conhecido como V, que pode adquirir habilidades de hacking e maquinários, um arsenal de armas de longo alcance e opções de combate no estilo corpo a corpo.",
                            Imagem = "cyberpunk2077.jpg",
                            Media = 0.0,
                            Nome = "CyberPunk2077",
                            Nota = 85.0,
                            Tipo = "Ação, Aventura, Mundo Aberto"
                        },
                        new
                        {
                            IdJogo = 3,
                            CategoriaIdade = "17+",
                            DataLancamento = new DateTime(2015, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "The Witcher 3: Wild Hunt é um jogo eletrónico de ação do subgénero RPG desenvolvido pela CD Projekt RED e lançado no dia 19 de maio de 2015 para as plataformas Microsoft Windows, PlayStation 4, Xbox One e em outubro de 2019 para a Nintendo Switch, sendo o terceiro título da série de jogos The Witcher.Ele sucede The Witcher e The Witcher 2: Assassins of Kings(2011), que foram baseados na série de livros de fantasia Wiedźmin, do escritor polonês Andrzej Sapkowski.",
                            Imagem = "TW3_Wild_Hunt.jpg",
                            Media = 0.0,
                            Nome = "The Witcher 3: Wild Hunt",
                            Nota = 93.0,
                            Tipo = "Ação, RPG"
                        },
                        new
                        {
                            IdJogo = 4,
                            CategoriaIdade = "17+",
                            DataLancamento = new DateTime(2017, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Assassin's Creed Origins é um jogo eletrónico de ação-aventura, produzido pela Ubisoft Montreal e publicado pela Ubisoft. É o décimo título principal da série Assassin's Creed e teve o seu lançamento a 27 de Outubro de 2017, para Microsoft Windows, PlayStation 4 e Xbox One, o jogo recebeu uma porta para o Google Stadia a 15 de Dezembro de 2020.",
                            Imagem = "AssassinsCreedOrigins.jpg",
                            Media = 0.0,
                            Nome = "Assassin's Creed Origins",
                            Nota = 84.0,
                            Tipo = "Ação, Aventura, RPG"
                        },
                        new
                        {
                            IdJogo = 5,
                            CategoriaIdade = "17+",
                            DataLancamento = new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Grand Theft Auto V é um jogo eletrónico de ação-aventura desenvolvido pela Rockstar North e publicado pela Rockstar Games. É o sétimo título principal da série Grand Theft Auto e foi lançado originalmente a 17 de setembro de 2013 para PlayStation 3 e Xbox 360, com remasterizações lançadas em 2014 para PlayStation 4 e Xbox One, em 2015 para Microsoft Windows e em 2021 para PlayStation 5 e Xbox Series X. O jogo passa-se no estado ficcional de San Andreas, com a história da campanha um jogador seguindo três criminosos e os seus esforços para realizarem assaltos sob a pressão de uma agência governamental. O mundo aberto permite que os jogadores naveguem livremente pelas áreas rurais e urbanas de San Andreas.",
                            Imagem = "GTAV.jpg",
                            Media = 0.0,
                            Nome = "Grand Thef Auto V",
                            Nota = 96.0,
                            Tipo = "Ação, Aventura, Mundo Aberto"
                        },
                        new
                        {
                            IdJogo = 6,
                            CategoriaIdade = "3+",
                            DataLancamento = new DateTime(2020, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Football Manager 2021 é um videojogo de simulação de gestão de futebol desenvolvido pela Sports Interactive e publicado pela Sega. Foi lançado mundialmente para iOS, Android, macOS e Windows em 24 de novembro de 2020.",
                            Imagem = "FootballManager2021.jpg",
                            Media = 0.0,
                            Nome = "Football Manager 2021",
                            Nota = 85.0,
                            Tipo = "Desporto, Simulação"
                        },
                        new
                        {
                            IdJogo = 7,
                            CategoriaIdade = "17+",
                            DataLancamento = new DateTime(2016, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Dark Souls III é um jogo do género RPG de ação, o quarto da série Souls, desenvolvido pela FromSoftware e co-realizado por Hidetaka Miyazaki, o criador da série. Dark Souls III foi lançado para Microsoft Windows, PlayStation 4 e Xbox One no dia 24 de março de 2016 no Japão, e a 12 de abril de 2016 no resto do mundo.",
                            Imagem = "DarkSouls3.jpg",
                            Media = 0.0,
                            Nome = "Dark Souls III",
                            Nota = 89.0,
                            Tipo = "Ação, RPG"
                        },
                        new
                        {
                            IdJogo = 8,
                            CategoriaIdade = "3+",
                            DataLancamento = new DateTime(2019, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Need for Speed Heat é um jogo eletrónico de corrida desenvolvido pela Ghost Games e publicado pela Electronic Arts para Microsoft Windows, PlayStation 4 e Xbox One. Este é o vigésimo quarto jogo de série Need for Speed e comemora o aniversário de 25 anos da série.",
                            Imagem = "NeedForSpeed.jpg",
                            Media = 0.0,
                            Nome = "Need for Speed Heat",
                            Nota = 72.0,
                            Tipo = "Corrida, Mundo Aberto"
                        },
                        new
                        {
                            IdJogo = 9,
                            CategoriaIdade = "3+",
                            DataLancamento = new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Ori and the Will of the Wisps é um jogo eletrónico metroidvania de aventura e plataforma desenvolvido pela Moon Studios e publicado pela Xbox Game Studios Europe para Xbox One, Nintendo Switch e Windows 10. É a sequência de Ori and the Blind Forest e foi lançado a 11 de março de 2020.",
                            Imagem = "OriAndTheWillOfTheWisps.jpg",
                            Media = 0.0,
                            Nome = "Ori and the Will of the Wisps",
                            Nota = 88.0,
                            Tipo = "Plataforma"
                        },
                        new
                        {
                            IdJogo = 10,
                            CategoriaIdade = "17+",
                            DataLancamento = new DateTime(2018, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Far Cry 5 é um jogo eletrónico de tiro em primeira pessoa de ação-aventura ambientado num mundo aberto.  Foi desenvolvido pela Ubisoft Montreal e publicado pela Ubisoft para Microsoft Windows, PlayStation 4 e Xbox One a 27 de março de 2018 e foi lançado a 3 de Novembro para o Google Stadia, junto com o Far Cry: New Dawn. É o décimo titulo da serie Far Cry e o quinto jogo principal.",
                            Imagem = "FarCry5.jpg",
                            Media = 0.0,
                            Nome = "FarCry 5",
                            Nota = 78.0,
                            Tipo = "Ação, Aventura, First Person Shooter"
                        });
                });

            modelBuilder.Entity("TrabPrático.Models.Loja", b =>
                {
                    b.Property<int>("IdLoja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagemLoja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JogoFK")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdLoja");

                    b.HasIndex("JogoFK");

                    b.ToTable("Loja");

                    b.HasData(
                        new
                        {
                            IdLoja = 1,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 1,
                            Link = "https://store.steampowered.com/app/1313860/EA_SPORTS_FIFA_21/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 2,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 2,
                            Link = "https://store.steampowered.com/app/1091500/Cyberpunk_2077/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 3,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 3,
                            Link = "https://store.steampowered.com/app/292030/The_Witcher_3_Wild_Hunt/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 4,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 4,
                            Link = "https://store.steampowered.com/app/582160/Assassins_Creed_Origins/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 5,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 5,
                            Link = "https://store.steampowered.com/app/271590/Grand_Theft_Auto_V/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 6,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 6,
                            Link = "https://store.steampowered.com/app/1263850/Football_Manager_2021/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 7,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 7,
                            Link = "https://store.steampowered.com/app/374320/DARK_SOULS_III/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 8,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 8,
                            Link = "https://store.steampowered.com/app/1222680/Need_for_Speed_Heat/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 9,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 9,
                            Link = "https://store.steampowered.com/app/1057090/Ori_and_the_Will_of_the_Wisps/",
                            Nome = "Steam"
                        },
                        new
                        {
                            IdLoja = 10,
                            ImagemLoja = "steamlogo.jpg",
                            JogoFK = 10,
                            Link = "https://store.steampowered.com/app/552520/Far_Cry_5/",
                            Nome = "Steam"
                        });
                });

            modelBuilder.Entity("TrabPrático.Models.Review", b =>
                {
                    b.Property<int>("IdReview")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataReview")
                        .HasColumnType("datetime2");

                    b.Property<int>("JogoFK")
                        .HasColumnType("int");

                    b.Property<double>("NotaReview")
                        .HasColumnType("float");

                    b.Property<int>("UtilizadorFK")
                        .HasColumnType("int");

                    b.Property<bool>("Visivel")
                        .HasColumnType("bit");

                    b.HasKey("IdReview");

                    b.HasIndex("JogoFK");

                    b.HasIndex("UtilizadorFK");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("TrabPrático.Models.Utilizador", b =>
                {
                    b.Property<int>("IdUtilizador")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("UserNameID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUtilizador");

                    b.ToTable("Utilizador");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TrabPrático.Models.Loja", b =>
                {
                    b.HasOne("TrabPrático.Models.Jogos", "Jogo")
                        .WithMany()
                        .HasForeignKey("JogoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");
                });

            modelBuilder.Entity("TrabPrático.Models.Review", b =>
                {
                    b.HasOne("TrabPrático.Models.Jogos", "Jogo")
                        .WithMany("JogosReview")
                        .HasForeignKey("JogoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrabPrático.Models.Utilizador", "Utilizador")
                        .WithMany("UserReview")
                        .HasForeignKey("UtilizadorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Jogo");

                    b.Navigation("Utilizador");
                });

            modelBuilder.Entity("TrabPrático.Models.Jogos", b =>
                {
                    b.Navigation("JogosReview");
                });

            modelBuilder.Entity("TrabPrático.Models.Utilizador", b =>
                {
                    b.Navigation("UserReview");
                });
#pragma warning restore 612, 618
        }
    }
}
