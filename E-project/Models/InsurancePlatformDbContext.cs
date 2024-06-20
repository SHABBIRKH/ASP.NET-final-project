using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace E_project.Models;

public partial class InsurancePlatformDbContext : DbContext
{
    public InsurancePlatformDbContext()
    {
    }

    public InsurancePlatformDbContext(DbContextOptions<InsurancePlatformDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppyLoan> AppyLoans { get; set; }

    public virtual DbSet<Createloan> Createloans { get; set; }

    public virtual DbSet<HealthPolicy> HealthPolicies { get; set; }

    public virtual DbSet<Holderspolicy> Holderspolicies { get; set; }

    public virtual DbSet<HomePolicy> HomePolicies { get; set; }

    public virtual DbSet<LifePolicy> LifePolicies { get; set; }

    public virtual DbSet<Loan> Loans { get; set; }

    public virtual DbSet<MotorPolicy> MotorPolicies { get; set; }

    public virtual DbSet<Plan> Plans { get; set; }

    public virtual DbSet<Policy> Policies { get; set; }

    public virtual DbSet<PolicyHolder> PolicyHolders { get; set; }

    public virtual DbSet<Term> Terms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=LAPPYSHAPPY\\SQLEXPRESS02;initial catalog=InsurancePlatformDb;user id=sa;password=SHSQL123; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppyLoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppyLoan__3214EC279B73A84B");

            entity.ToTable("AppyLoan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmountIntrest)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Amount_intrest");
            entity.Property(e => e.ApprovelStatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Pending")
                .HasColumnName("Approvel_status");
            entity.Property(e => e.CnicPhoto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CNIC_Photo");
            entity.Property(e => e.Cnicno).HasColumnName("CNICNO");
            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Expiredat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("expiredat");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.IssueDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Occupation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PermentAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Photo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("photo");
            entity.Property(e => e.WhyYouWantLoan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Why_you_want_Loan");
        });

        modelBuilder.Entity<Createloan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__createlo__3213E83F6CC1A13C");

            entity.ToTable("createloan");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Loanname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("loanname");
            entity.Property(e => e.Totalamount).HasColumnName("totalamount");
            entity.Property(e => e.Totalduration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("totalduration");
        });

        modelBuilder.Entity<HealthPolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__health_p__3213E83F3831FA8A");

            entity.ToTable("health_policy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.Premium).HasColumnName("premium");
        });

        modelBuilder.Entity<Holderspolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__holdersp__3213E83F9124B955");

            entity.ToTable("holderspolicy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Cardexp).HasColumnName("cardexp");
            entity.Property(e => e.Cardno).HasColumnName("cardno");
            entity.Property(e => e.Dateofbirth).HasColumnName("dateofbirth");
            entity.Property(e => e.Emailaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("emailaddress");
            entity.Property(e => e.Firstname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Gender)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Lastname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Phoneno).HasColumnName("phoneno");
        });

        modelBuilder.Entity<HomePolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__home_pol__3213E83FF71E5F40");

            entity.ToTable("home_policy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.Premium).HasColumnName("premium");
        });

        modelBuilder.Entity<LifePolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__life_pol__3213E83FDE28F786");

            entity.ToTable("life_policy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.Premium).HasColumnName("premium");
        });

        modelBuilder.Entity<Loan>(entity =>
        {
            entity.HasKey(e => e.LoanId).HasName("PK__loans__A1F79554FA565332");

            entity.ToTable("loans");

            entity.Property(e => e.LoanId).HasColumnName("loan_id");
            entity.Property(e => e.InterestRate)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Interest_rate");
            entity.Property(e => e.LoanAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("loan_amount");
            entity.Property(e => e.LoanEndDate).HasColumnName("loan_end_date");
            entity.Property(e => e.LoanStartDate).HasColumnName("loan_start_date");
            entity.Property(e => e.PolicyHolder).HasColumnName("policy_holder");
            entity.Property(e => e.PolicyId).HasColumnName("policy_id");

            entity.HasOne(d => d.PolicyHolderNavigation).WithMany(p => p.Loans)
                .HasForeignKey(d => d.PolicyHolder)
                .HasConstraintName("FK__loans__policy_ho__59063A47");

            entity.HasOne(d => d.Policy).WithMany(p => p.Loans)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("FK__loans__policy_id__5812160E");
        });

        modelBuilder.Entity<MotorPolicy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__motor_po__3213E83F857C37CF");

            entity.ToTable("motor_policy");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("created_by");
            entity.Property(e => e.CreationDate).HasColumnName("creation_date");
            entity.Property(e => e.Details)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("details");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.ExpirationDate).HasColumnName("expiration_date");
            entity.Property(e => e.Premium).HasColumnName("premium");
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity.HasKey(e => e.PlanId).HasName("PK__plans__BE9F8F1D799C0380");

            entity.ToTable("plans");

            entity.Property(e => e.PlanId).HasColumnName("plan_id");
            entity.Property(e => e.CoverageAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("coverage_amount");
            entity.Property(e => e.PlanName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("plan_name");
            entity.Property(e => e.PremiumAmount)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Premium_amount");
            entity.Property(e => e.TermId).HasColumnName("term_id");

            entity.HasOne(d => d.Term).WithMany(p => p.Plans)
                .HasForeignKey(d => d.TermId)
                .HasConstraintName("FK__plans__term_id__619B8048");
        });

        modelBuilder.Entity<Policy>(entity =>
        {
            entity.HasKey(e => e.PolicyId).HasName("PK__policies__47DA3F0351DCB72C");

            entity.ToTable("policies");

            entity.Property(e => e.PolicyId).HasColumnName("policy_id");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate).HasColumnName("Effective_date");
            entity.Property(e => e.ExpirationDate).HasColumnName("Expiration_date");
            entity.Property(e => e.PolicyAmount).HasColumnName("policy_amount");
            entity.Property(e => e.PolicyDetails)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("policy_details");
            entity.Property(e => e.PolicyName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("policy_name");
        });

        modelBuilder.Entity<PolicyHolder>(entity =>
        {
            entity.HasKey(e => e.PolicyholderId).HasName("PK__policy_h__507E5DD43C135175");

            entity.ToTable("policy_holders");

            entity.Property(e => e.PolicyholderId).HasColumnName("policyholder_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Email_address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.PhoneNumber).HasColumnName("Phone_number");
        });

        modelBuilder.Entity<Term>(entity =>
        {
            entity.HasKey(e => e.TermId).HasName("PK__terms__4CCB0634AFBAC208");

            entity.ToTable("terms");

            entity.Property(e => e.TermId).HasColumnName("term_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.TermName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("term_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__users__B9BE370FEFA33EC3");

            entity.ToTable("users");

            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
