namespace StoreDB.Model.Partials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
     
    /// <summary>
    /// �޲z�̸��
    /// </summary>
    public partial class AspNetUsers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetRoles = new HashSet<AspNetRoles>();
        }

        [DisplayName("�ϥΪ�ID")]
        public string Id { get; set; }

        [Required(ErrorMessage = "�b����������J���")]
        [DisplayName("�b��")] //Add
        public string Account { get; set; }

        [StringLength(256)]
        [EmailAddress(ErrorMessage ="�DE-Mail�榡")]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        [DisplayName("�K�X����")]
        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        [DisplayName("�q�ܸ��X")]
        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        [DisplayName("��w����ɶ���")]
        public DateTime? LockoutEndDateUtc { get; set; }

        [DisplayName("�O�_�n���ҿ��~����")]
        public bool LockoutEnabled { get; set; }

        [DisplayName("��J���~����")]
        public int AccessFailedCount { get; set; }

        [DisplayName("�إ߮ɶ�")] //Add
        public DateTime CreateTime { get; set; }

        [DisplayName("��s�ɶ�")] //Add
        public DateTime UpdateTime { get; set; }

        [Required]
        [StringLength(256)]
        [DisplayName("�ϥΪ̦W��")]
        public string UserName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetRoles> AspNetRoles { get; set; }
    }
}
