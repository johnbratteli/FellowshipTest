﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// DataAnnotations tags added by hand

using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 

namespace FellowshipTest.Models
{

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("person", Namespace = "", IsNullable = false)]
    public partial class Person
    {

        private string titleField;

        private string salutationField;

        private string prefixField;

        private string firstNameField;

        private string lastNameField;

        private string suffixField;

        private string middleNameField;

        private string goesByNameField;

        private string formerNameField;

        private System.Nullable<gender> genderField;

        //private System.Nullable<System.DateTime> dateOfBirthField;
        private string dateOfBirthField;

        private System.Nullable<maritalStatus> maritalStatusField;

        private HouseholdMemberType householdMemberTypeField;

        private List<Address> addressesField;

        private List<Communication> communicationsField;

        private string isAuthorizedField;

        private Status statusField;

        private Occupation occupationField;

        private string employerField;

        private School schoolField;

        private Denomination denominationField;

        private string formerChurchField;

        private string barCodeField;

        private string memberEnvelopeCodeField;

        private string defaultTagCommentField;

        private Weblink weblinkField;

        private string solicitField;

        private string thankField;

        //private System.Nullable<System.DateTime> firstRecordField;
        private string firstRecordField;

        private object lastMatchDateField;

        //private System.Nullable<System.DateTime> createdDateField;
        private string createdDateField;

        //private System.Nullable<System.DateTime> lastUpdatedDateField;
        private string lastUpdatedDateField;

        private string uriField;

        private string imageURIField;

        private string idField;

        private string oldIDField;

        private string oldHouseholdIDField;

        private string iCodeField;

        private string householdIDField;

        public Person() {
            //this.dateOfBirthField = new System.DateTime(0);
            //this.firstRecordField = new System.DateTime(0);
            //this.createdDateField = new System.DateTime(0);
            //this.lastUpdatedDateField = new System.DateTime(0);
            this.householdMemberType = new HouseholdMemberType();
            this.status = new Status();
            this.occupation = new Occupation();
            this.school = new School();
            this.denomination = new Denomination();
        }

        /// <remarks/>
        [Display(Name = "Title")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string salutation
        {
            get
            {
                return this.salutationField;
            }
            set
            {
                this.salutationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string prefix
        {
            get
            {
                return this.prefixField;
            }
            set
            {
                this.prefixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string firstName
        {
            get
            {
                return this.firstNameField;
            }
            set
            {
                this.firstNameField = value;
            }
        }

        /// <remarks/>
        public string lastName
        {
            get
            {
                return this.lastNameField;
            }
            set
            {
                this.lastNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string suffix
        {
            get
            {
                return this.suffixField;
            }
            set
            {
                this.suffixField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string middleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string goesByName
        {
            get
            {
                return this.goesByNameField;
            }
            set
            {
                this.goesByNameField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Former Name")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string formerName
        {
            get
            {
                return this.formerNameField;
            }
            set
            {
                this.formerNameField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Gender")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<gender> gender
        {
            get
            {
                return this.genderField;
            }
            set
            {
                this.genderField = value;
            }
        }

        /* working around problem with deserializing datetimes
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> dateOfBirth {
            get {
                return this.dateOfBirthField;
            }
            set {
                this.dateOfBirthField = value;
            }
        }
        */
        [Display(Name = "DOB")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string dateOfBirth
        {
            get
            {
                return this.dateOfBirthField;
            }
            set
            {
                this.dateOfBirthField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Marital Status")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<maritalStatus> maritalStatus
        {
            get
            {
                return this.maritalStatusField;
            }
            set
            {
                this.maritalStatusField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Household Member Type")]
        public HouseholdMemberType householdMemberType
        {
            get
            {
                return this.householdMemberTypeField;
            }
            set
            {
                this.householdMemberTypeField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Addresses")]
        [UIHint("Address")]
        public List<Address> addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Communication Methods")]
        [UIHint("Communication")]
        public List<Communication> communications
        {
            get
            {
                return this.communicationsField;
            }
            set
            {
                this.communicationsField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Authorized?")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string isAuthorized
        {
            get
            {
                return this.isAuthorizedField;
            }
            set
            {
                this.isAuthorizedField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Status")]
        public Status status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Occupation")]
        public Occupation occupation
        {
            get
            {
                return this.occupationField;
            }
            set
            {
                this.occupationField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Employer")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string employer
        {
            get
            {
                return this.employerField;
            }
            set
            {
                this.employerField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "School")]
        public School school
        {
            get
            {
                return this.schoolField;
            }
            set
            {
                this.schoolField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Denomination")]
        public Denomination denomination
        {
            get
            {
                return this.denominationField;
            }
            set
            {
                this.denominationField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Former Church")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string formerChurch
        {
            get
            {
                return this.formerChurchField;
            }
            set
            {
                this.formerChurchField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Bar Code")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string barCode
        {
            get
            {
                return this.barCodeField;
            }
            set
            {
                this.barCodeField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Member Envelope Code")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string memberEnvelopeCode
        {
            get
            {
                return this.memberEnvelopeCodeField;
            }
            set
            {
                this.memberEnvelopeCodeField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Default Tag Comment")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string defaultTagComment
        {
            get
            {
                return this.defaultTagCommentField;
            }
            set
            {
                this.defaultTagCommentField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Weblink")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Weblink weblink
        {
            get
            {
                return this.weblinkField;
            }
            set
            {
                this.weblinkField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Solicit?")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string solicit
        {
            get
            {
                return this.solicitField;
            }
            set
            {
                this.solicitField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Thank?")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string thank
        {
            get
            {
                return this.thankField;
            }
            set
            {
                this.thankField = value;
            }
        }

        /*
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> firstRecord {
            get {
                return this.firstRecordField;
            }
            set {
                this.firstRecordField = value;
            }
        }
        */
        [Display(Name = "First Record")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string firstRecord
        {
            get
            {
                return this.firstRecordField;
            }
            set
            {
                this.firstRecordField = value;
            }
        }

        /// <remarks/>
        // CODEGEN Warning: 'default' attribute supported only for primitive types.  Ignoring default='0001-01-01T00:00:00' attribute.
        [Display(Name = "Last Match Date")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public object lastMatchDate
        {
            get
            {
                return this.lastMatchDateField;
            }
            set
            {
                this.lastMatchDateField = value;
            }
        }

        /*
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> createdDate {
            get {
                return this.createdDateField;
            }
            set {
                this.createdDateField = value;
            }
        }
        */
        [Display(Name = "Created Date")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string createdDate
        {
            get
            {
                return this.createdDateField;
            }
            set
            {
                this.createdDateField = value;
            }
        }

        /*
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> lastUpdatedDate {
            get {
                return this.lastUpdatedDateField;
            }
            set {
                this.lastUpdatedDateField = value;
            }
        }
        */
        [Display(Name = "Last Updated Date")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string lastUpdatedDate
        {
            get
            {
                return this.lastUpdatedDateField;
            }
            set
            {
                this.lastUpdatedDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string imageURI
        {
            get
            {
                return this.imageURIField;
            }
            set
            {
                this.imageURIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string oldID
        {
            get
            {
                return this.oldIDField;
            }
            set
            {
                this.oldIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string oldHouseholdID
        {
            get
            {
                return this.oldHouseholdIDField;
            }
            set
            {
                this.oldHouseholdIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string iCode
        {
            get
            {
                return this.iCodeField;
            }
            set
            {
                this.iCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string householdID
        {
            get
            {
                return this.householdIDField;
            }
            set
            {
                this.householdIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public enum gender
    {

        /// <remarks/>
        Male,

        /// <remarks/>
        Female,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = true)]
    public enum maritalStatus
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Child/Yth")]
        ChildYth,

        /// <remarks/>
        Divorced,

        /// <remarks/>
        Married,

        /// <remarks/>
        Separated,

        /// <remarks/>
        Single,

        /// <remarks/>
        Widow,

        /// <remarks/>
        Widower,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("householdMemberType", Namespace = "", IsNullable = false)]
    public partial class HouseholdMemberType
    {

        private System.Nullable<householdMemberTypeName> nameField;

        private string uriField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public System.Nullable<householdMemberTypeName> name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public enum householdMemberTypeName
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("")]
        Item,

        /// <remarks/>
        Head,

        /// <remarks/>
        Spouse,

        /// <remarks/>
        Child,

        /// <remarks/>
        Other,

        /// <remarks/>
        Visitor,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("status", Namespace = "", IsNullable = false)]
    public partial class Status
    {

        private string nameField;

        private string commentField;

        private string dateField;

        private SubStatus subStatusField;

        private string uriField;

        private short idField;

        public Status()
        {
            this.dateField = "0001-01-01T00:00:00";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }

        /// <remarks/>
        public SubStatus subStatus
        {
            get
            {
                return this.subStatusField;
            }
            set
            {
                this.subStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public short id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("subStatus", Namespace = "", IsNullable = false)]
    public partial class SubStatus
    {

        private string nameField;

        private string uriField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("occupation", Namespace = "", IsNullable = false)]
    public partial class Occupation
    {

        private string nameField;

        private string descriptionField;

        private string uriField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("school", Namespace = "", IsNullable = false)]
    public partial class School
    {

        private string nameField;

        private string uriField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("denomination", Namespace = "", IsNullable = false)]
    public partial class Denomination
    {

        private string nameField;

        private string uriField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
        public string uri
        {
            get
            {
                return this.uriField;
            }
            set
            {
                this.uriField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("weblink", Namespace = "", IsNullable = true)]
    public partial class Weblink
    {

        private string userIDField;

        private string passwordHintField;

        private string passwordAnswerField;

        public Weblink()
        {
            this.userIDField = "";
            this.passwordHintField = "";
            this.passwordAnswerField = "";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string userID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string passwordHint
        {
            get
            {
                return this.passwordHintField;
            }
            set
            {
                this.passwordHintField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = true)]
        public string passwordAnswer
        {
            get
            {
                return this.passwordAnswerField;
            }
            set
            {
                this.passwordAnswerField = value;
            }
        }
    }
}