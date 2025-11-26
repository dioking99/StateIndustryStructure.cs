using System.Collections.Generic;

namespace CompanyFinder.Models
{
    public class StateIndustryStructure
    {
        public string StateName { get; set; } = string.Empty;
        public List<Industry> Industries { get; set; } = new();
    }

    public class Industry
    {
        public string IndustryName { get; set; } = string.Empty;
        public List<string> SubIndustries { get; set; } = new();
    }

    public static class IndustryData
    {
        private static List<Industry> GetIndustries(bool includePrivateHouseholds)
        {
            var servicesSubIndustries = new List<string>
            {
                "Hotels, Rooming Houses, Camps, and Other Lodging Places",
                "Personal Services",
                "Business Services",
                "Automotive Repair, Services, and Parking",
                "Miscellaneous Repair Services",
                "Motion Pictures",
                "Amusement and Recreation Services",
                "Health Services",
                "Legal Services",
                "Educational Services",
                "Social Services",
                "Museums, Art Galleries, and Botanical and Zoological Gardens",
                "Membership Organizations",
                "Engineering, Accounting, Research, Management, and Related Services"
            };

            if (includePrivateHouseholds)
            {
                servicesSubIndustries.Add("Private Households");
            }

            servicesSubIndustries.Add("Miscellaneous Services NEC");

            return new List<Industry>
            {
                new Industry
                {
                    IndustryName = "Agriculture, Forestry, And Fishing",
                    SubIndustries = new List<string>
                    {
                        "Agricultural Production Crops",
                        "Agricultural Production Livestock and Animal Specialties",
                        "Agricultural Services",
                        "Forestry",
                        "Fishing, Hunting, and Trapping"
                    }
                },
                new Industry
                {
                    IndustryName = "Construction",
                    SubIndustries = new List<string>
                    {
                        "Building Construction General Contractors and Operative Builders",
                        "Heavy Construction Other Than Building Construction Contractors",
                        "Construction Special Trade Contractors"
                    }
                },
                new Industry
                {
                    IndustryName = "Finance, Insurance, And Real Estate",
                    SubIndustries = new List<string>
                    {
                        "Depository Institutions",
                        "Non-depository Credit Institutions",
                        "Security and Commodity Brokers, Dealers, Exchanges, and Services",
                        "Insurance Carriers",
                        "Insurance Agents, Brokers, and Service",
                        "Real Estate",
                        "Holding and Other Investment Offices"
                    }
                },
                new Industry
                {
                    IndustryName = "Manufacturing",
                    SubIndustries = new List<string>
                    {
                        "Food and Kindred Products",
                        "Tobacco Products",
                        "Textile Mill Products",
                        "Apparel and Other Finished Products Made From Fabrics and Similar Materials",
                        "Lumber and Wood Products, Except Furniture",
                        "Furniture and Fixtures",
                        "Paper and Allied Products",
                        "Printing, Publishing, and Allied Industries",
                        "Chemicals and Allied Products",
                        "Petroleum Refining and Related Industries",
                        "Rubber and Miscellaneous Plastics Products",
                        "Leather and Leather Products",
                        "Stone, Clay, Glass, and Concrete Products",
                        "Primary Metal Industries",
                        "Fabricated Metal Products, Except Machinery and Transportation Equipment",
                        "Industrial and Commercial Machinery and Computer Equipment",
                        "Electronic and Other Electrical Equipment and Components, Except Computer Equipment",
                        "Transportation Equipment",
                        "Measuring, Analyzing, and Controlling Instruments; Photographic, Medical and Optical Goods; Watches and Clocks",
                        "Miscellaneous Manufacturing Industries"
                    }
                },
                new Industry
                {
                    IndustryName = "Mining",
                    SubIndustries = new List<string>
                    {
                        "Metal Mining",
                        "Coal Mining",
                        "Oil and Gas Extraction",
                        "Mining and Quarrying of Nonmetallic Minerals, Except Fuels"
                    }
                },
                new Industry
                {
                    IndustryName = "Public Administration",
                    SubIndustries = new List<string>
                    {
                        "Executive, Legislative, and General Government, Except Finance",
                        "Justice, Public Order, and Safety",
                        "Public Finance, Taxation, and Monetary Policy",
                        "Administration of Human Resource Programs",
                        "Administration of Environmental Quality and Housing Programs",
                        "Administration of Economic Programs",
                        "National Security and International Affairs",
                        "Nonclassifiable Establishments"
                    }
                },
                new Industry
                {
                    IndustryName = "Retail Trade",
                    SubIndustries = new List<string>
                    {
                        "Building Materials, Hardware, Garden Supply, and Mobile Home Dealers",
                        "General Merchandise Stores",
                        "Food Stores",
                        "Automotive Dealers and Gasoline Service Stations",
                        "Apparel and Accessory Stores",
                        "Home Furniture, Furnishings, and Equipment Stores",
                        "Eating and Drinking Places",
                        "Miscellaneous Retail"
                    }
                },
                new Industry
                {
                    IndustryName = "Services",
                    SubIndustries = servicesSubIndustries
                },
                new Industry
                {
                    IndustryName = "Transportation, Communications, Electric, Gas, And Sanitary Services",
                    SubIndustries = new List<string>
                    {
                        "Railroad Transportation",
                        "Local and Suburban Transit and Interurban Highway Passenger Transportation",
                        "Motor Freight Transportation and Warehousing",
                        "United States Postal Service",
                        "Water Transportation",
                        "Transportation By Air",
                        "Pipelines, Except Natural Gas",
                        "Transportation Services",
                        "Communications",
                        "Electric, Gas, and Sanitary Services"
                    }
                },
                new Industry
                {
                    IndustryName = "Wholesale Trade",
                    SubIndustries = new List<string>
                    {
                        "Wholesale Trade - Durable Goods",
                        "Wholesale Trade - Non-Durable Goods"
                    }
                }
            };
        }

        private static StateIndustryStructure CreateState(string stateName, bool includePrivateHouseholds)
        {
            return new StateIndustryStructure
            {
                StateName = stateName,
                Industries = GetIndustries(includePrivateHouseholds)
            };
        }

        public static Dictionary<string, StateIndustryStructure> States { get; } = new()
        {
            { "Alabama", CreateState("Alabama", false) },
            { "Alaska", CreateState("Alaska", true) },
            { "Arizona", CreateState("Arizona", false) },
            { "Arkansas", CreateState("Arkansas", false) },
            { "California", CreateState("California", true) },
            { "Colorado", CreateState("Colorado", false) },
            { "Connecticut", CreateState("Connecticut", true) },
            { "Delaware", CreateState("Delaware", false) },
            { "Florida", CreateState("Florida", true) },
            { "Georgia", CreateState("Georgia", true) },
            { "Hawaii", CreateState("Hawaii", false) },
            { "Idaho", CreateState("Idaho", false) },
            { "Illinois", CreateState("Illinois", true) },
            { "Indiana", CreateState("Indiana", false) },
            { "Iowa", CreateState("Iowa", true) },
            { "Kansas", CreateState("Kansas", true) },
            { "Kentucky", CreateState("Kentucky", false) },
            { "Louisiana", CreateState("Louisiana", true) },
            { "Maine", CreateState("Maine", false) },
            { "Maryland", CreateState("Maryland", true) },
            { "Massachusetts", CreateState("Massachusetts", true) },
            { "Michigan", CreateState("Michigan", true) },
            { "Minnesota", CreateState("Minnesota", true) },
            { "Mississippi", CreateState("Mississippi", false) },
            { "Missouri", CreateState("Missouri", true) },
            { "Montana", CreateState("Montana", false) },
            { "Nebraska", CreateState("Nebraska", true) },
            { "Nevada", CreateState("Nevada", true) },
            { "New Hampshire", CreateState("New Hampshire", true) },
            { "New Jersey", CreateState("New Jersey", true) },
            { "New Mexico", CreateState("New Mexico", false) },
            { "New York", CreateState("New York", true) },
            { "North Carolina", CreateState("North Carolina", false) },
            { "North Dakota", CreateState("North Dakota", false) },
            { "Ohio", CreateState("Ohio", false) },
            { "Oklahoma", CreateState("Oklahoma", false) },
            { "Oregon", CreateState("Oregon", false) },
            { "Pennsylvania", CreateState("Pennsylvania", true) },
            { "Rhode Island", CreateState("Rhode Island", false) },
            { "South Carolina", CreateState("South Carolina", false) },
            { "South Dakota", CreateState("South Dakota", false) },
            { "Tennessee", CreateState("Tennessee", false) },
            { "Texas", CreateState("Texas", true) },
            { "Utah", CreateState("Utah", true) },
            { "Vermont", CreateState("Vermont", false) },
            { "Virginia", CreateState("Virginia", true) },
            { "Washington", CreateState("Washington", true) },
            { "West Virginia", CreateState("West Virginia", false) },
            { "Wisconsin", CreateState("Wisconsin", false) },
            { "Wyoming", CreateState("Wyoming", false) }
        };
    }
}
