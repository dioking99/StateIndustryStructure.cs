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
        private static readonly List<string> AgricultureSubIndustries = new()
        {
            "Agricultural Production Crops",
            "Agricultural Production Livestock and Animal Specialties",
            "Agricultural Services",
            "Forestry",
            "Fishing, Hunting, and Trapping"
        };

        private static readonly List<string> ConstructionSubIndustries = new()
        {
            "Building Construction General Contractors and Operative Builders",
            "Heavy Construction Other Than Building Construction Contractors",
            "Construction Special Trade Contractors"
        };

        private static readonly List<string> FinanceSubIndustries = new()
        {
            "Depository Institutions",
            "Non-depository Credit Institutions",
            "Security and Commodity Brokers, Dealers, Exchanges, and Services",
            "Insurance Carriers",
            "Insurance Agents, Brokers, and Service",
            "Real Estate",
            "Holding and Other Investment Offices"
        };

        private static readonly List<string> ManufacturingSubIndustries = new()
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
        };

        private static readonly List<string> MiningSubIndustries = new()
        {
            "Metal Mining",
            "Coal Mining",
            "Oil and Gas Extraction",
            "Mining and Quarrying of Nonmetallic Minerals, Except Fuels"
        };

        private static readonly List<string> PublicAdministrationSubIndustries = new()
        {
            "Executive, Legislative, and General Government, Except Finance",
            "Justice, Public Order, and Safety",
            "Public Finance, Taxation, and Monetary Policy",
            "Administration of Human Resource Programs",
            "Administration of Environmental Quality and Housing Programs",
            "Administration of Economic Programs",
            "National Security and International Affairs",
            "Nonclassifiable Establishments"
        };

        private static readonly List<string> RetailTradeSubIndustries = new()
        {
            "Building Materials, Hardware, Garden Supply, and Mobile Home Dealers",
            "General Merchandise Stores",
            "Food Stores",
            "Automotive Dealers and Gasoline Service Stations",
            "Apparel and Accessory Stores",
            "Home Furniture, Furnishings, and Equipment Stores",
            "Eating and Drinking Places",
            "Miscellaneous Retail"
        };

        private static readonly List<string> ServicesSubIndustriesBase = new()
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
            "Engineering, Accounting, Research, Management, and Related Services",
            "Miscellaneous Services NEC"
        };

        private static readonly List<string> TransportationSubIndustries = new()
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
        };

        private static readonly List<string> WholesaleTradeSubIndustries = new()
        {
            "Wholesale Trade - Durable Goods",
            "Wholesale Trade - Non-Durable Goods"
        };

        private static readonly HashSet<string> StatesWithPrivateHouseholds = new()
        {
            "Alaska", "California", "Connecticut", "Florida", "Georgia",
            "Illinois", "Iowa", "Kansas", "Louisiana", "Maryland",
            "Massachusetts", "Missouri", "Nebraska", "Nevada", "New Hampshire",
            "New Jersey", "Pennsylvania", "Texas", "Utah", "Virginia", "Washington"
        };

        private static List<string> GetServicesSubIndustries(string stateName)
        {
            var services = new List<string>(ServicesSubIndustriesBase);
            if (StatesWithPrivateHouseholds.Contains(stateName))
            {
                services.Insert(services.Count - 1, "Private Households");
            }
            return services;
        }

        private static StateIndustryStructure CreateStateStructure(string stateName)
        {
            return new StateIndustryStructure
            {
                StateName = stateName,
                Industries = new List<Industry>
                {
                    new Industry
                    {
                        IndustryName = "Agriculture, Forestry, And Fishing",
                        SubIndustries = new List<string>(AgricultureSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Construction",
                        SubIndustries = new List<string>(ConstructionSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Finance, Insurance, And Real Estate",
                        SubIndustries = new List<string>(FinanceSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Manufacturing",
                        SubIndustries = new List<string>(ManufacturingSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Mining",
                        SubIndustries = new List<string>(MiningSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Public Administration",
                        SubIndustries = new List<string>(PublicAdministrationSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Retail Trade",
                        SubIndustries = new List<string>(RetailTradeSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Services",
                        SubIndustries = GetServicesSubIndustries(stateName)
                    },
                    new Industry
                    {
                        IndustryName = "Transportation, Communications, Electric, Gas, And Sanitary Services",
                        SubIndustries = new List<string>(TransportationSubIndustries)
                    },
                    new Industry
                    {
                        IndustryName = "Wholesale Trade",
                        SubIndustries = new List<string>(WholesaleTradeSubIndustries)
                    }
                }
            };
        }

        public static Dictionary<string, StateIndustryStructure> States { get; } = new()
        {
            { "Alabama", CreateStateStructure("Alabama") },
            { "Alaska", CreateStateStructure("Alaska") },
            { "Arizona", CreateStateStructure("Arizona") },
            { "Arkansas", CreateStateStructure("Arkansas") },
            { "California", CreateStateStructure("California") },
            { "Colorado", CreateStateStructure("Colorado") },
            { "Connecticut", CreateStateStructure("Connecticut") },
            { "Delaware", CreateStateStructure("Delaware") },
            { "Florida", CreateStateStructure("Florida") },
            { "Georgia", CreateStateStructure("Georgia") },
            { "Hawaii", CreateStateStructure("Hawaii") },
            { "Idaho", CreateStateStructure("Idaho") },
            { "Illinois", CreateStateStructure("Illinois") },
            { "Indiana", CreateStateStructure("Indiana") },
            { "Iowa", CreateStateStructure("Iowa") },
            { "Kansas", CreateStateStructure("Kansas") },
            { "Kentucky", CreateStateStructure("Kentucky") },
            { "Louisiana", CreateStateStructure("Louisiana") },
            { "Maine", CreateStateStructure("Maine") },
            { "Maryland", CreateStateStructure("Maryland") },
            { "Massachusetts", CreateStateStructure("Massachusetts") },
            { "Michigan", CreateStateStructure("Michigan") },
            { "Minnesota", CreateStateStructure("Minnesota") },
            { "Mississippi", CreateStateStructure("Mississippi") },
            { "Missouri", CreateStateStructure("Missouri") },
            { "Montana", CreateStateStructure("Montana") },
            { "Nebraska", CreateStateStructure("Nebraska") },
            { "Nevada", CreateStateStructure("Nevada") },
            { "New Hampshire", CreateStateStructure("New Hampshire") },
            { "New Jersey", CreateStateStructure("New Jersey") },
            { "New Mexico", CreateStateStructure("New Mexico") },
            { "New York", CreateStateStructure("New York") },
            { "North Carolina", CreateStateStructure("North Carolina") },
            { "North Dakota", CreateStateStructure("North Dakota") },
            { "Ohio", CreateStateStructure("Ohio") },
            { "Oklahoma", CreateStateStructure("Oklahoma") },
            { "Oregon", CreateStateStructure("Oregon") },
            { "Pennsylvania", CreateStateStructure("Pennsylvania") },
            { "Rhode Island", CreateStateStructure("Rhode Island") },
            { "South Carolina", CreateStateStructure("South Carolina") },
            { "South Dakota", CreateStateStructure("South Dakota") },
            { "Tennessee", CreateStateStructure("Tennessee") },
            { "Texas", CreateStateStructure("Texas") },
            { "Utah", CreateStateStructure("Utah") },
            { "Vermont", CreateStateStructure("Vermont") },
            { "Virginia", CreateStateStructure("Virginia") },
            { "Washington", CreateStateStructure("Washington") },
            { "West Virginia", CreateStateStructure("West Virginia") },
            { "Wisconsin", CreateStateStructure("Wisconsin") },
            { "Wyoming", CreateStateStructure("Wyoming") }
        };
    }
}
