using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace WebconIntegrationSystem.Models.BPSMainAtt
{
    //[NotMapped]
    [Table("WFAttachmentFiles", Schema = "dbo")]
    public partial class WfattachmentFiles : /*MvxViewModel, */INotifyPropertyChanged
    {
        //[Key]
        //[Column("ATF_ID")]
        //public int AtfId { get; set; }

        #region private int _atfId; public int AtfId
        private int _atfId;

        [Key]
        [Column("ATF_ID")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfId))]
        [Display(Name = nameof(AtfId), Prompt = nameof(AtfId), Description = nameof(AtfId))]
        public int AtfId
        {
            get => _atfId;
            set
            {
                if (value != _atfId)
                {
                    _atfId = value;
                    OnPropertyChanged(nameof(AtfId));
                }
            }
        }
        #endregion

        //[Column("ATF_WFDID")]
        //public int? AtfWfdid { get; set; }

        #region private int? _atfWfdid; public int? AtfWfdid
        private int? _atfWfdid;

        [Column("ATF_WFDID")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfWfdid))]
        [Display(Name = nameof(AtfWfdid), Prompt = nameof(AtfWfdid), Description = nameof(AtfWfdid))]
        public int? AtfWfdid
        {
            get => _atfWfdid;
            set
            {
                if (value != _atfWfdid)
                {
                    _atfWfdid = value;
                    OnPropertyChanged(nameof(AtfWfdid));
                }
            }
        }
        #endregion

        //[Column("ATF_ATTID")]
        //public int AtfAttid { get; set; }

        #region private int _atfAttid; public int AtfAttid
        private int _atfAttid;

        [Column("ATF_ATTID")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfAttid))]
        [Display(Name = nameof(AtfAttid), Prompt = nameof(AtfAttid), Description = nameof(AtfAttid))]
        public int AtfAttid
        {
            get => _atfAttid;
            set
            {
                if (value != _atfAttid)
                {
                    _atfAttid = value;
                    OnPropertyChanged(nameof(AtfAttid));
                }
            }
        }
        #endregion

        //[Column("ATF_Value", TypeName = "image")]
        //public byte[] AtfValue { get; set; }

        #region private byte[] _atfValue; public byte[] AtfValue
        private byte[] _atfValue;

        [Column("ATF_Value", TypeName = "image")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfValue))]
        [Display(Name = nameof(AtfValue), Prompt = nameof(AtfValue), Description = nameof(AtfValue))]
        public byte[] AtfValue
        {
            get => _atfValue;
            set
            {
                if (value != _atfValue)
                {
                    _atfValue = value;
                    OnPropertyChanged(nameof(AtfValue));
                }
            }
        }
        #endregion

        //[Column("ATF_TSInsert", TypeName = "datetime")]
        //public DateTime AtfTsinsert { get; set; }

        #region private DateTime _atfTsinsert; public DateTime AtfTsinsert
        private DateTime _atfTsinsert;

        [Column("ATF_TSInsert", TypeName = "datetime")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfTsinsert))]
        [Display(Name = nameof(AtfTsinsert), Prompt = nameof(AtfTsinsert), Description = nameof(AtfTsinsert))]
        [Required]
        public DateTime AtfTsinsert
        {
            get => _atfTsinsert;
            set
            {
                if (value != _atfTsinsert)
                {
                    _atfTsinsert = value;
                    OnPropertyChanged(nameof(AtfTsinsert));
                }
            }
        }
        #endregion

        //[Column("ATF_TSUpdate", TypeName = "datetime")]
        //public DateTime AtfTsupdate { get; set; }

        #region private DateTime _atfTsupdate; public DateTime AtfTsupdate
        private DateTime _atfTsupdate;

        [Column("ATF_TSUpdate", TypeName = "datetime")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfTsupdate))]
        [Display(Name = nameof(AtfTsupdate), Prompt = nameof(AtfTsupdate), Description = nameof(AtfTsupdate))]
        [Required]
        public DateTime AtfTsupdate
        {
            get => _atfTsupdate;
            set
            {
                if (value != _atfTsupdate)
                {
                    _atfTsupdate = value;
                    OnPropertyChanged(nameof(AtfTsupdate));
                }
            }
        }
        #endregion

        //[Required]
        //[Column("ATF_RowVersion")]
        //public byte[] AtfRowVersion { get; set; }

        #region private byte[] _atfRowVersion; public byte[] AtfRowVersion
        private byte[] _atfRowVersion;

        [Column("ATF_RowVersion")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfRowVersion))]
        [Display(Name = nameof(AtfRowVersion), Prompt = nameof(AtfRowVersion), Description = nameof(AtfRowVersion))]
        [Required]
        public byte[] AtfRowVersion
        {
            get => _atfRowVersion;
            set
            {
                if (value != _atfRowVersion)
                {
                    _atfRowVersion = value;
                    OnPropertyChanged(nameof(AtfRowVersion));
                }
            }
        }
        #endregion

        //[Column("ATF_IsDeleted")]
        //public bool AtfIsDeleted { get; set; }

        #region private bool _atfIsDeleted; public bool AtfIsDeleted
        private bool _atfIsDeleted;

        [Column("ATF_IsDeleted")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfIsDeleted))]
        [Display(Name = nameof(AtfIsDeleted), Prompt = nameof(AtfIsDeleted), Description = nameof(AtfIsDeleted))]
        public bool AtfIsDeleted
        {
            get => _atfIsDeleted;
            set
            {
                if (value != _atfIsDeleted)
                {
                    _atfIsDeleted = value;
                    OnPropertyChanged(nameof(AtfIsDeleted));
                }
            }
        }
        #endregion

        //[Column("ATF_Version")]
        //public int AtfVersion { get; set; }

        #region private int _atfVersion; public int AtfVersion
        private int _atfVersion;

        [Column("ATF_Version")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfVersion))]
        [Display(Name = nameof(AtfVersion), Prompt = nameof(AtfVersion), Description = nameof(AtfVersion))]
        [Range(0, 2147483647)]
        public int AtfVersion
        {
            get => _atfVersion;
            set
            {
                if (value != _atfVersion)
                {
                    _atfVersion = value;
                    OnPropertyChanged(nameof(AtfVersion));
                }
            }
        }
        #endregion

        //[Column("ATF_AttachmentImage", TypeName = "image")]
        //public byte[] AtfAttachmentImage { get; set; }

        #region private byte[] _atfAttachmentImage; public byte[] AtfAttachmentImage
        private byte[] _atfAttachmentImage;

        [Column("ATF_AttachmentImage", TypeName = "image")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfAttachmentImage))]
        [Display(Name = nameof(AtfAttachmentImage), Prompt = nameof(AtfAttachmentImage), Description = nameof(AtfAttachmentImage))]
        public byte[] AtfAttachmentImage
        {
            get => _atfAttachmentImage;
            set
            {
                if (value != _atfAttachmentImage)
                {
                    _atfAttachmentImage = value;
                    OnPropertyChanged(nameof(AtfAttachmentImage));
                }
            }
        }
        #endregion

        //[Column("ATF_FlexiData")]
        //public string AtfFlexiData { get; set; }

        #region private string _atfFlexiData; public string AtfFlexiData
        private string _atfFlexiData;

        [Column("ATF_FlexiData")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfFlexiData))]
        [Display(Name = nameof(AtfFlexiData), Prompt = nameof(AtfFlexiData), Description = nameof(AtfFlexiData))]
        public string AtfFlexiData
        {
            get => _atfFlexiData;
            set
            {
                if (value != _atfFlexiData)
                {
                    _atfFlexiData = value;
                    OnPropertyChanged(nameof(AtfFlexiData));
                }
            }
        }
        #endregion

        //[Column("ATF_AttributesMapping")]
        //public string AtfAttributesMapping { get; set; }

        #region private string _atfAttributesMapping; public string AtfAttributesMapping
        private string _atfAttributesMapping;

        [Column("ATF_AttributesMapping")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfAttributesMapping))]
        [Display(Name = nameof(AtfAttributesMapping), Prompt = nameof(AtfAttributesMapping), Description = nameof(AtfAttributesMapping))]
        public string AtfAttributesMapping
        {
            get => _atfAttributesMapping;
            set
            {
                if (value != _atfAttributesMapping)
                {
                    _atfAttributesMapping = value;
                    OnPropertyChanged(nameof(AtfAttributesMapping));
                }
            }
        }
        #endregion

        //[Column("ATF_OrginalValueHash")]
        //[MaxLength(32)]
        //public byte[] AtfOrginalValueHash { get; set; }

        #region private byte[] _atfOrginalValueHash; public byte[] AtfOrginalValueHash
        private byte[] _atfOrginalValueHash;

        [Column("ATF_OrginalValueHash")]
        [MaxLength(32)]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfOrginalValueHash))]
        [Display(Name = nameof(AtfOrginalValueHash), Prompt = nameof(AtfOrginalValueHash), Description = nameof(AtfOrginalValueHash))]
        public byte[] AtfOrginalValueHash
        {
            get => _atfOrginalValueHash;
            set
            {
                if (value != _atfOrginalValueHash)
                {
                    _atfOrginalValueHash = value;
                    OnPropertyChanged(nameof(AtfOrginalValueHash));
                }
            }
        }
        #endregion

        //[Required]
        //[Column("ATF_FileType")]
        //[StringLength(20)]
        //public string AtfFileType { get; set; }

        #region private string _atfFileType; public string AtfFileType
        private string _atfFileType;

        [Required]
        [Column("ATF_FileType")]
        [StringLength(20)]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfFileType))]
        [Display(Name = nameof(AtfFileType), Prompt = nameof(AtfFileType), Description = nameof(AtfFileType))]
        public string AtfFileType
        {
            get => _atfFileType;
            set
            {
                if (value != _atfFileType)
                {
                    _atfFileType = value;
                    OnPropertyChanged(nameof(AtfFileType));
                }
            }
        }
        #endregion

        //[Column("ATF_CreatedBy")]
        //[StringLength(255)]
        //public string AtfCreatedBy { get; set; }

        #region private string _atfCreatedBy; public string AtfCreatedBy
        private string _atfCreatedBy;

        [Column("ATF_CreatedBy")]
        [StringLength(255)]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfCreatedBy))]
        [Display(Name = nameof(AtfCreatedBy), Prompt = nameof(AtfCreatedBy), Description = nameof(AtfCreatedBy))]
        public string AtfCreatedBy
        {
            get => _atfCreatedBy;
            set
            {
                if (value != _atfCreatedBy)
                {
                    _atfCreatedBy = value;
                    OnPropertyChanged(nameof(AtfCreatedBy));
                }
            }
        }
        #endregion

        //[Column("ATF_UpdatedBy")]
        //[StringLength(255)]
        //public string AtfUpdatedBy { get; set; }

        #region private string _atfUpdatedBy; public string AtfUpdatedBy
        private string _atfUpdatedBy;

        [Column("ATF_UpdatedBy")]
        [StringLength(255)]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfUpdatedBy))]
        [Display(Name = nameof(AtfUpdatedBy), Prompt = nameof(AtfUpdatedBy), Description = nameof(AtfUpdatedBy))]
        public string AtfUpdatedBy
        {
            get => _atfUpdatedBy;
            set
            {
                if (value != _atfUpdatedBy)
                {
                    _atfUpdatedBy = value;
                    OnPropertyChanged(nameof(AtfUpdatedBy));
                }
            }
        }
        #endregion

        //[Column("ATF_OrginalName")]
        //[StringLength(255)]
        //public string AtfOrginalName { get; set; }

        #region private string _atfOrginalName; public string AtfOrginalName
        private string _atfOrginalName;

        [Column("ATF_OrginalName")]
        [StringLength(255)]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfOrginalName))]
        [Display(Name = nameof(AtfOrginalName), Prompt = nameof(AtfOrginalName), Description = nameof(AtfOrginalName))]
        public string AtfOrginalName
        {
            get => _atfOrginalName;
            set
            {
                if (value != _atfOrginalName)
                {
                    _atfOrginalName = value;
                    OnPropertyChanged(nameof(AtfOrginalName));
                }
            }
        }
        #endregion

        //[Column("ATF_FRData")]
        //public string AtfFrdata { get; set; }

        #region private string _atfFrdata; public string AtfFrdata
        private string _atfFrdata;

        [Column("ATF_FRData")]
        [Editable(false)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [JsonProperty(nameof(AtfFrdata))]
        [Display(Name = nameof(AtfFrdata), Prompt = nameof(AtfFrdata), Description = nameof(AtfFrdata))]
        public string AtfFrdata
        {
            get => _atfFrdata;
            set
            {
                if (value != _atfFrdata)
                {
                    _atfFrdata = value;
                    OnPropertyChanged(nameof(AtfFrdata));
                }
            }
        }
        #endregion

        #region public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// PropertyChangedEventHandler PropertyChanged
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        /// <summary>
        /// protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, args);
            //base.PropertyChanged += PropertyChanged;
        }
        #endregion

        #region private void OnPropertyChanged(string propertyName)
        /// <summary>
        /// private void OnPropertyChanged(string propertyName)
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}