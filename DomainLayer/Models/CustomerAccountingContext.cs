using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DomainLayer.Models
{
    public partial class CustomerAccountingContext : DbContext
    {
        public CustomerAccountingContext()
        {
        }

        public CustomerAccountingContext(DbContextOptions<CustomerAccountingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAtStock> ProductAtStocks { get; set; }
        public virtual DbSet<ProductOrder> ProductOrders { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=customer_accounting;Username=postgres;Password=webLAbl51");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Russian_Russia.1251");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("address");

                entity.HasIndex(e => e.AddressInfo, "address_address_info_key")
                    .IsUnique();

                entity.Property(e => e.AddressId)
                    .HasColumnName("address_id")
                    .HasDefaultValueSql("nextval('address_sq'::regclass)");

                entity.Property(e => e.AddressInfo)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("address_info");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.HasIndex(e => e.ClientEmail, "client_client_email_key")
                    .IsUnique();

                entity.HasIndex(e => e.ClientUsername, "client_client_username_key")
                    .IsUnique();

                entity.Property(e => e.ClientId)
                    .HasColumnName("client_id")
                    .HasDefaultValueSql("nextval('client_sq'::regclass)");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.ClientEmail)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("client_email");

                entity.Property(e => e.ClientFullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("client_full_name");

                entity.Property(e => e.ClientPassword)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("client_password");

                entity.Property(e => e.ClientPhoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("client_phone_number");

                entity.Property(e => e.ClientUsername)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("client_username");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("client_address_id_fkey");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("discount");

                entity.HasIndex(e => e.DiscountName, "discount_discount_name_key")
                    .IsUnique();

                entity.Property(e => e.DiscountId)
                    .HasColumnName("discount_id")
                    .HasDefaultValueSql("nextval('discount_sq'::regclass)");

                entity.Property(e => e.DiscountName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("discount_name");

                entity.Property(e => e.DiscountPerecentage).HasColumnName("discount_perecentage");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasDefaultValueSql("nextval('product_sq'::regclass)");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductSellingPrice).HasColumnName("product_selling_price");

                entity.Property(e => e.ProviderId).HasColumnName("provider_id");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_provider_id_fkey");
            });

            modelBuilder.Entity<ProductAtStock>(entity =>
            {
                entity.ToTable("product_at_stock");

                entity.Property(e => e.ProductAtStockId)
                    .HasColumnName("product_at_stock_id")
                    .HasDefaultValueSql("nextval('product_at_stock_sq'::regclass)");

                entity.Property(e => e.ProductAtStockDate)
                    .HasColumnType("date")
                    .HasColumnName("product_at_stock_date");

                entity.Property(e => e.ProductAtStockQuantity).HasColumnName("product_at_stock_quantity");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.WarehouseId).HasColumnName("warehouse_id");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAtStocks)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_at_stock_product_id_fkey");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ProductAtStocks)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_at_stock_warehouse_id_fkey");
            });

            modelBuilder.Entity<ProductOrder>(entity =>
            {
                entity.ToTable("product_order");

                entity.Property(e => e.ProductOrderId)
                    .HasColumnName("product_order_id")
                    .HasDefaultValueSql("nextval('product_order_sq'::regclass)");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.DiscountId).HasColumnName("discount_id");

                entity.Property(e => e.OrderState)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("order_state");

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("payment_type");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductOrderDate)
                    .HasColumnType("date")
                    .HasColumnName("product_order_date");

                entity.Property(e => e.ProductOrderPrice).HasColumnName("product_order_price");

                entity.Property(e => e.ProductOrderQuantity).HasColumnName("product_order_quantity");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_order_client_id_fkey");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_order_discount_id_fkey");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductOrders)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("product_order_product_id_fkey");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("provider");

                entity.HasIndex(e => e.ProviderCompanyName, "provider_provider_company_name_key")
                    .IsUnique();

                entity.HasIndex(e => e.ProviderEmail, "provider_provider_email_key")
                    .IsUnique();

                entity.Property(e => e.ProviderId)
                    .HasColumnName("provider_id")
                    .HasDefaultValueSql("nextval('provider_sq'::regclass)");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.ProviderCompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("provider_company_name");

                entity.Property(e => e.ProviderEmail)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("provider_email");

                entity.Property(e => e.ProviderPhoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("provider_phone_number");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Providers)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("provider_address_id_fkey");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("warehouse");

                entity.HasIndex(e => e.WarehouseName, "warehouse_warehouse_name_key")
                    .IsUnique();

                entity.Property(e => e.WarehouseId)
                    .HasColumnName("warehouse_id")
                    .HasDefaultValueSql("nextval('warehouse_sq'::regclass)");

                entity.Property(e => e.WarehouseName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("warehouse_name");

                entity.Property(e => e.WarehouserFullname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("warehouser_fullname");
            });

            modelBuilder.HasSequence<int>("address_sq");

            modelBuilder.HasSequence<int>("client_sq");

            modelBuilder.HasSequence<int>("discount_sq");

            modelBuilder.HasSequence<int>("product_at_stock_sq");

            modelBuilder.HasSequence<int>("product_order_sq");

            modelBuilder.HasSequence<int>("product_sq");

            modelBuilder.HasSequence<int>("provider_sq");

            modelBuilder.HasSequence<int>("warehouse_sq");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}