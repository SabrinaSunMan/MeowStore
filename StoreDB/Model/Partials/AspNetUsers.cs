namespace StoreDB.Model.Partials
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

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
        /// <summary>
        /// �޲z�� �ϥΪ�ID.
        /// </summary> 
        [DisplayName("�ϥΪ�ID")]
        public string Id { get; set; }
          
        [StringLength(256)]
        [EmailAddress(ErrorMessage ="�DE-Mail�榡")]
        [DisplayName("�b��")]
        public string Email { get; set; }


        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// �K�X����.
        /// </summary> 
        [DisplayName("�K�X����")]
        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        /// <summary>
        /// �q�ܸ��X.
        /// </summary> 
        [DisplayName("�q�ܸ��X")]
        public string PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        /// <summary>
        /// ��w����ɶ���.
        /// </summary> 
        [DisplayName("��w����ɶ���")]
        public DateTime? LockoutEndDateUtc { get; set; }

        /// <summary>
        /// �O�_�n���ҿ��~����.
        /// </summary> 
        [DisplayName("�O�_�n���ҿ��~����")]
        public bool LockoutEnabled { get; set; }

        /// <summary>
        /// ��J���~����.
        /// </summary> 
        [DisplayName("��J���~����")]
        public int AccessFailedCount { get; set; }

        /// <summary>
        /// �إ߮ɶ�.
        /// </summary> 
        [DisplayName("�إ߮ɶ�")] //Add
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// ��s�ɶ�.
        /// </summary> 
        [DisplayName("��s�ɶ�")] //Add
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// �ϥΪ̦W��.
        /// </summary> 
        [Required]
        [StringLength(256)]
        [DisplayName("�ϥΪ̦W��")]
        public string UserName { get; set; }

        public virtual ICollection<Group> GroupID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetRoles> AspNetRoles { get; set; }
    }
}
