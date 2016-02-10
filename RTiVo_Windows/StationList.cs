using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTiVo_Windows
{
    public class StationList
    {
        public int[] fakedStations = {10110, 10270, 10310, 10570,10710,10250,8850,10690,10350,11111,12111}; //this needs to be created in the constructor by querying the radio board
        private List<Station> availableStations;
        public StationList()
        {
            availableStations = new List<Station>(); //iterate through available stations and add them to the list of available stations
            //BUILD STATION LIST PASSED BACK FROM THE ARDUINO HERE
            foreach(int stationNumber in fakedStations)
            {
                availableStations.Add(new Station(stationNumber));
            }
        }

        public List<Station> getAvailableStations()
        {
            return availableStations;
        }
    }
}
