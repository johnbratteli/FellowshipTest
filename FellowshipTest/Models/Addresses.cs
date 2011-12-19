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
using System.Web.Mvc;
using System.Reflection;

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
    [System.Xml.Serialization.XmlRootAttribute("address", Namespace = "", IsNullable = false)]
    public partial class Address
    {

        private Household householdField;

        private Person personField;

        private AddressType addressTypeField;

        private string address1Field;

        private string address2Field;

        private string address3Field;

        private string cityField;

        private string postalCodeField;

        private string countyField;

        private string countryField;

        private string stProvinceField;

        private string carrierRouteField;

        private string deliveryPointField;

        //private System.Nullable<System.DateTime> addressDateField;
        private string addressDateField;

        private string addressCommentField;

        private string uspsVerifiedField;

        //private System.Nullable<System.DateTime> addressVerifiedDateField;
        private string addressVerifiedDateField;
        //private System.Nullable<System.DateTime> lastVerificationAttemptDateField;
        private string lastVerificationAttemptDateField;
        //private System.Nullable<System.DateTime> createdDateField;
        private string createdDateField;
        //private System.Nullable<System.DateTime> lastUpdatedDateField;
        private string lastUpdatedDateField;

        private string uriField;

        private string idField;

        /*
        public address() {
            this.addressDateField = new System.DateTime(0);
            this.addressVerifiedDateField = new System.DateTime(0);
            this.lastVerificationAttemptDateField = new System.DateTime(0);
            this.createdDateField = new System.DateTime(0);
            this.lastUpdatedDateField = new System.DateTime(0);
        }
        */

        // default constructor for no-context address
        public Address() 
        {
            this.person = new Person();
            this.addressType = new AddressType();
        }

        // constructor for address with person context
        public Address(string personID, string personURI, AddressType type)
        {
            this.person = new Person();
            this.person.id = personID;
            this.person.uri = personURI;
            this.addressType = type;
        }

        public Address(FormCollection collection)
        {
            // the current object should look like source when we're done
            Address source = (Address) Utility.constructorCollectionHelper(collection, typeof(Address));
            foreach (var pInfo in this.GetType().GetProperties())
            {
                pInfo.SetValue(this, pInfo.GetValue(source, null), null);
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Household household
        {
            get
            {
                return this.householdField;
            }
            set
            {
                this.householdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public Person person
        {
            get
            {
                return this.personField;
            }
            set
            {
                this.personField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public AddressType addressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Address 1")]
        public string address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Address 2")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string address2
        {
            get
            {
                return this.address2Field;
            }
            set
            {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Address 3")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string address3
        {
            get
            {
                return this.address3Field;
            }
            set
            {
                this.address3Field = value;
            }
        }

        /// <remarks/>
        [Display(Name = "City")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Postal Code")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string postalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "County")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string county
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Country")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Province")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string stProvince
        {
            get
            {
                return this.stProvinceField;
            }
            set
            {
                this.stProvinceField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Carrier Route")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string carrierRoute
        {
            get
            {
                return this.carrierRouteField;
            }
            set
            {
                this.carrierRouteField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Delivery Point")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string deliveryPoint
        {
            get
            {
                return this.deliveryPointField;
            }
            set
            {
                this.deliveryPointField = value;
            }
        }

        /* working around problem with deserializing datetimes
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> addressDate {
            get {
                return this.addressDateField;
            }
            set {
                this.addressDateField = value;
            }
        }
        */
        /// <remarks/>
        [Display(Name = "Address Date")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string addressDate
        {
            get
            {
                return this.addressDateField;
            }
            set
            {
                this.addressDateField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Comment")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string addressComment
        {
            get
            {
                return this.addressCommentField;
            }
            set
            {
                this.addressCommentField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "USPS Verified?")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string uspsVerified
        {
            get
            {
                return this.uspsVerifiedField;
            }
            set
            {
                this.uspsVerifiedField = value;
            }
        }

        /* working around problem with deserializing datetimes
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> addressVerifiedDate {
            get {
                return this.addressVerifiedDateField;
            }
            set {
                this.addressVerifiedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> lastVerificationAttemptDate {
            get {
                return this.lastVerificationAttemptDateField;
            }
            set {
                this.lastVerificationAttemptDateField = value;
            }
        }
    
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
        /// <remarks/>
        [Display(Name = "Address Verification")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string addressVerifiedDate
        {
            get
            {
                return this.addressVerifiedDateField;
            }
            set
            {
                this.addressVerifiedDateField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Last Verification Attempt")]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string lastVerificationAttemptDate
        {
            get
            {
                return this.lastVerificationAttemptDateField;
            }
            set
            {
                this.lastVerificationAttemptDateField = value;
            }
        }

        /// <remarks/>
        [Display(Name = "Created")]
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

        /// <remarks/>
        [Display(Name = "Last Updated")]
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
    [System.Xml.Serialization.XmlRootAttribute("household", Namespace = "", IsNullable = false)]
    public partial class Household
    {

        private string uriField;

        private string idField;

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
    [System.Xml.Serialization.XmlRootAttribute("addressType", Namespace = "", IsNullable = false)]
    public partial class AddressType
    {

        private object nameField;

        private string uriField;

        private string idField;

        public AddressType() { }

        public AddressType(int id, string name, string uri)
        {
            this.id = id.ToString();
            this.name = name;
            this.uri = uri;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public object name
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
}