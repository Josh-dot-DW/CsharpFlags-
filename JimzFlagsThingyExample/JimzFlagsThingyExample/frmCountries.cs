using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JimzFlagsThingyExample
{
    public partial class frmCountries : Form //This labels the form we've built
    {
        public frmCountries() 
        {
            InitializeComponent(); //This makes the form begin compiling
        }

        private void chkTitle_CheckedChanged(object sender, EventArgs e)
        {
            lblTitle.Visible = chkTitle.Checked; //This tells the system to check to see if the title button is selected
        }

        private void chkProgrammer_CheckedChanged(object sender, EventArgs e)
        {
            lblProgrammer.Visible = chkProgrammer.Checked; //This tells the system to see if the programmer button is selected
        }

        private void chkVersion_CheckedChanged(object sender, EventArgs e)
        {
            lblVersion.Visible = chkVersion.Checked; //This tells the system to see if the version button is selected
        }

        private void chkFlag_CheckedChanged(object sender, EventArgs e)
        {
            picFlags.Visible = chkFlag.Checked; //This tells the system to see if the falg button is selected
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            txtCountryInfo.Visible = chkInfo.Checked; //This tells the system to see if the info button is selected
        }

        //The section below goes through each radial button selection for each flag
        //it's basically saying that when each seperate selection is made display this information into the labled location.

        //lblCountryName.Text - display this name in the label above
        //txtCountryInfo.Text - display this information in the text box below

        //As long as the radial button is selected for that specific flag the rest of the information will populate into teh designated text boxes and labels
        //All of these functions are using a click event to call the event and display the string

        private void rdoVirginIslands_Click(object sender, EventArgs e)
        {
            picFlags.Image = lstFlags.Images[0];
            lblCountryName.Text = "British Virgin Islands";
            txtCountryInfo.Text = "        The British Virgin Islands (BVI), officially the Virgin Islands, is a British overseas territory located in the Caribbean to the east of Puerto Rico. The islands make up part of the Virgin Islands archipelago; the remaining islands constitute the U.S. Virgin Islands and the Spanish Virgin Islands.\r\n        The official name of the Territory is still simply the \"Virgin Islands\", but the prefix \"British\" is often used to distinguish it from the neighbouring American territory which changed its name from the \"Danish West Indies\" to \"Virgin Islands of the United States\" in 1917. British Virgin Islands government publications continue to begin with the name \"The Territory of the Virgin Islands\", and the Territory's passports simply refer to the \"Virgin Islands\", and all laws begin with the words \"Virgin Islands\". Moreover, the Territory's Constitutional Commission has expressed the view that \"every effort should be made\", to encourage the use of the name \"Virgin Islands\".\r\n        The British Virgin Islands consist of the main islands of Tortola, Virgin Gorda, Anegada, and Jost Van Dyke, along with over fifty other smaller islands and cays. About 15 of the islands are inhabited. The capital, Road Town, is situated on Tortola, the largest island, which is approximately 20 km (12 mi) long and 5 km (3 mi) wide. The islands have a population of about 28,000, of whom approximately 23,500 live on Tortola.\r\n       British Virgin Islanders are classed as British Overseas Territories citizens and since 2002 have had an entitlement to take up full UK citizenship. Although the territory is not part of the European Union and not directly subject to EU law, its citizens are deemed to be citizens of the EU as well.";
        }

        private void rdoCaymanIslands_Click(object sender, EventArgs e)
        {
            picFlags.Image = lstFlags.Images[1];
            lblCountryName.Text = "Cayman Islands";
            txtCountryInfo.Text = "         The Cayman Islands (/'ke?m?n/ or /ke?'mæn/) are a British Overseas Territory in the western Caribbean Sea. The territory comprises the three islands of Grand Cayman, Cayman Brac and Little Cayman, located south of Cuba and northwest of Jamaica. The Cayman Islands are considered to be part of the geographic Western Caribbean Zone as well as the Greater Antilles. The territory is often considered a major world offshore financial haven for many wealthier individuals.";
        }

        private void rdoCookIslands_Click(object sender, EventArgs e)
        {
            picFlags.Image = lstFlags.Images[2];
            lblCountryName.Text = "Cook Islands";
            txtCountryInfo.Text = "        The Cook Islands (Listeni/'k?k 'a?l?ndz/; Cook Islands Maori: Kuki 'Airani) is an island country in the South Pacific Ocean in free association with New Zealand. It comprises 15 islands whose total land area is 240 square kilometres (92.7 sq mi). The Cook Islands' Exclusive Economic Zone (EEZ), however, covers 1,800,000 square kilometres (690,000 sq mi) of ocean.\r\n        The Cook Islands' defence and foreign affairs are the responsibility of New Zealand, which is exercised in consultation with the Cook Islands. In recent times, the Cook Islands have adopted an increasingly independent foreign policy. Although Cook Islanders are citizens of New Zealand, they have the status of Cook Islands nationals, which is not given to other New Zealand citizens.\r\n        The Cook Islands' main population centres are on the island of Rarotonga (10,572 in 2011), where there is an international airport. There is a larger population of Cook Islanders in New Zealand, particularly the North Island. In the 2006 census, 58,008 self-identified as being of ethnic Cook Islands Maori descent.\r\n        With about 100,000 visitors travelling to the islands in the 2010–11 financial year, tourism is the country's main industry, and the leading element of the economy, ahead of offshore banking, pearls, and marine and fruit exports.";
        }

        private void rdoFalklandIslands_Click(object sender, EventArgs e)
        {
            picFlags.Image = lstFlags.Images[3];
            lblCountryName.Text = "Falkland Islands";
            txtCountryInfo.Text = "        The Falkland Islands (/'f??lkl?nd/; Spanish: Islas Malvinas [mal'ßinas]) are an archipelago in the South Atlantic Ocean on the Patagonian Shelf. The principal islands are about 300 miles (480 km) east of South America's southern Patagonian coast, at a latitude of about 52°S. The archipelago, with an area of 4,700 square miles (12,000 km2), comprises East Falkland, West Falkland and 776 smaller islands. As a British overseas territory, the Falklands have internal self-governance, and the United Kingdom takes responsibility for their defence and foreign affairs. The islands' capital is Stanley on East Falkland.\r\n        Controversy exists over the Falklands' discovery and subsequent colonisation by Europeans. At various times, the islands have had French, British, Spanish, and Argentine settlements. Britain reasserted its rule in 1833, although Argentina maintains its claim to the islands. In April 1982, Argentine forces temporarily occupied the islands. British administration was restored two months later at the end of the Falklands War.\r\n        The population (2,932 inhabitants in 2012) primarily consists of native-born Falkland Islanders, the majority of British descent. Other ethnicities include French, Gibraltarian and Scandinavian. Immigration from the United Kingdom, the South Atlantic island of Saint Helena, and Chile has reversed a population decline. The predominant (and official) language is English. Under the British Nationality (Falkland Islands) Act 1983, Falkland Islanders are British citizens.\r\n        The islands lie on the boundary of the subantarctic oceanic and tundra climate zones, and both major islands have mountain ranges reaching 2,300 feet (700 m). They are home to large bird populations, although many no longer breed on the main islands because of competition from introduced species. Major economic activities include fishing, tourism and sheep farming, with an emphasis on high-quality wool exports. Oil exploration, licensed by the Falkland Islands Government, remains controversial as a result of maritime disputes with Argentina.";
        }

        private void rdoPitcairnIslands_Click(object sender, EventArgs e)
        {
            picFlags.Image = lstFlags.Images[4];
            lblCountryName.Text = "Pitcairn Islands";
            txtCountryInfo.Text = "        The Pitcairn Islands (/'p?tk??rn/; Pitkern: Pitkern Ailen), officially Pitcairn, are a group of four volcanic islands in the southern Pacific Ocean that form the last British Overseas Territory in the Pacific. The four islands – Pitcairn, Henderson, Ducie, and Oeno – are spread over several hundred miles of ocean and have a total land area of about 47 square kilometres (18 sq mi). Only Pitcairn, the second largest island measuring about 3.6 kilometres (2.2 mi) from east to west, is inhabited.\r\n        The islands are inhabited by the descendants of the Bounty mutineers and the Tahitians (or Polynesians) who accompanied them, an event retold in numerous books and films. This history is still apparent in the surnames of many of the islanders. With only about 56 inhabitants, originating from four main families, Pitcairn is the least populous national jurisdiction in the world. The United Nations Committee on Decolonization includes the Pitcairn Islands on the United Nations list of Non-Self-Governing Territories.";
        }

        private void rdoTurksAndCaicosIslands_Click(object sender, EventArgs e)
        {
            picFlags.Image = lstFlags.Images[5];
            lblCountryName.Text = "Turks and Caicos Islands";
            txtCountryInfo.Text = "        The Turks and Caicos Islands (/'t??rks/ and /'ke?k?s/ / /'ke?ko?s/ / /'ke?k?s/), or TCI for short, are a British Overseas Territory consisting of the larger Caicos Islands and smaller Turks Islands, two groups of tropical islands in the Lucayan Archipelago, north of the larger Antilles island grouping. They are known primarily for tourism and as an offshore financial centre. The resident population is about 49,000, of whom 23,769 live on Providenciales in the Caicos Islands. The total population on the islands including foreigners is approximately 49,000.\r\n        The Turks and Caicos Islands lie southeast of Mayaguana in the Bahamas island chain and north of the island of Hispaniola. Cockburn Town, the capital since 1766, is situated on Grand Turk Island about 1,042 kilometres (647 mi) east-southeast of Miami, United States. The islands have a total land area of 430 square kilometres (170 sq mi).\r\n        The first recorded European sighting of the islands now known as the Turks and Caicos occurred in 1512. In the subsequent centuries, the islands were claimed by several European powers with the British Empire eventually gaining control. For many years the islands were governed indirectly through Bermuda, the Bahamas, and Jamaica. When the Bahamas gained independence in 1973, the islands received their own governor and have remained a separate autonomous British Overseas Territory since. In August 2009, the United Kingdom suspended the Turks and Caicos Islands' self-government after allegations of ministerial corruption. Home rule was restored in the islands after the November 2012 elections.";
        }
    }
}
