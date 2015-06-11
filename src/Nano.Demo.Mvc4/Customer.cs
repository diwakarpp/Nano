﻿using System.Collections;
using System.Collections.Generic;

namespace Nano.Demo.Mvc4
{
    /// <summary>
    /// Customer API.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Creates the customer.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns>Customer.</returns>
        public static CustomerModel CreateCustomer( string firstName, string lastName )
        {
            return new CustomerModel
            {
                CustomerId = 1,
                FirstName = firstName,
                LastName = lastName
            };
        }

        /// <summary>
        /// Gets a person by <see cref="personId"/>.
        /// </summary>
        /// <param name="personId">The person identifier.</param>
        /// <returns>Person.</returns>
        public static Person GetPerson( int personId )
        {
            return new Person
            {
                PersonId = personId,
                FirstName = "Clark",
                LastName = "Kent",
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressId = 1,
                        Address1 = "100 Sweet Street",
                        Address2 = "",
                        City = "Metropolis",
                        State = "NY",
                        ZipCode = "10548"
                    },
                    new Address
                    {
                        AddressId = 1,
                        Address1 = "200 Sweet Street",
                        Address2 = "",
                        City = "Metropolis",
                        State = "NY",
                        ZipCode = "10548"
                    }
                }
            };
        }

        /// <summary>
        /// Gets a customer.
        /// </summary>
        /// <param name="customerNbr">The customer number.</param>
        /// <returns>Customer object.</returns>
        public static object GetCustomer( int customerNbr )
        {
            return new
            {
                CustomerNbr = customerNbr,
                FirstName = "Clark",
                LastName = "Kent"
            };
        }

        /// <summary>
        /// Returns NanoContext stuff.
        /// </summary>
        /// <param name="nanoContext">The nano context.</param>
        /// <returns>NanoContext stuff.</returns>
        public static object GetContext( dynamic nanoContext )
        {
            return new
            {
                nanoContext.Request.Url,
                HttpMethod = nanoContext.Request.HttpMethod
            };
        }

        /// <summary>
        /// Creates a <span style="font-weight: bold;">customer</span>. Wiki article: <a href="https://wiki.ambitenergy.com/wiki/5378/developer-protocol-sdlc">Weston's Rant</a>
        /// <p onclick="alert('Yo dog, I heard you like JavaScript so I put JavaScript in your HTML description in your XML method comments in your C# class!')">
        ///     Look, there's HTML in my XML comments... <i>crazy!!!</i>
        /// </p>
        /// </summary>
        /// <param name="firstName">First name.</param>
        /// <param name="lastName">Last name.</param>
        /// <returns>Customer.</returns>
        public static CustomerModel CreatePendingCustomer( string firstName, string lastName = null )
        {
            return new CustomerModel
            {
                CustomerId = 1,
                FirstName = firstName,
                LastName = lastName
            };
        }

        /// <summary>
        /// Creates a customer.
        /// </summary>
        /// <param name="customer">Customer model.</param>
        /// <returns>Customer.</returns>
        public static dynamic CreateDynamicCustomer( dynamic customer )
        {
            return new
            {
                customer.CustomerId,
                customer.FirstName,
                customer.LastName
            };
        }

        /// <summary>
        /// Customer.
        /// </summary>
        public class CustomerModel
        {
            /// <summary>
            /// The customer identifier.
            /// </summary>
            public int CustomerId;

            /// <summary>
            /// First name.
            /// </summary>
            public string FirstName;

            /// <summary>
            /// Last name.
            /// </summary>
            public string LastName;
        }

        /// <summary>
        /// Person.
        /// </summary>
        public class Person
        {
            /// <summary>
            /// The person identifier.
            /// </summary>
            public int PersonId;

            /// <summary>
            /// First name.
            /// </summary>
            public string FirstName;

            /// <summary>
            /// Last name.
            /// </summary>
            public string LastName;

            /// <summary>
            /// The persons list of addresses.
            /// </summary>
            public IList<Address> Addresses = new List<Address>();
        }

        /// <summary>
        /// Address.
        /// </summary>
        public class Address
        {
            /// <summary>
            /// The address identifier.
            /// </summary>
            public int AddressId;

            /// <summary>
            /// The address line 1.
            /// </summary>
            public string Address1;

            /// <summary>
            /// The address line 2.
            /// </summary>
            public string Address2;

            /// <summary>
            /// The city.
            /// </summary>
            public string City;

            /// <summary>
            /// The state.
            /// </summary>
            public string State;

            /// <summary>
            /// The zip code.
            /// </summary>
            public string ZipCode;
        }
    }
}