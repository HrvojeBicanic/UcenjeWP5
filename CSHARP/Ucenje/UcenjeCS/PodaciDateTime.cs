﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    // Koliko je ukupno elemenata u nizu?
    // Koliko je elemenata niza u mjesecu srpnju?
    // Koliko elemenata niza ima zapis s 7 sekundi?
    // Koja je prosječna vrijednost svih zapisa za minute?
    // U kojim sve godinama postoje zapisi?
    // Koliko je zapisa koji se mogu pojaviti samo u prijestupnim godinama?
    // Koliko je zapisa čije je vrijeme između 4 i 5 sati u noći?
    public class PodaciDateTime
    {

        public static DateTime[] Niz()
        {

            DateTime[] niz = new DateTime[Podaci.Length];
            for (int i = 0; i < Podaci.Length; i++)
            {
                niz[i] = DateTime.Parse(Podaci[i]);
            }
            return niz; 

        }
        private static String[] Podaci = {
        "2024-04-30 03:43:36",
"2024-07-13 05:23:13",
"2024-11-21 07:55:35",
"2024-09-08 07:01:49",
"2024-08-28 11:17:17",
"2024-03-02 01:07:28",
"2024-10-23 06:28:27",
"2024-01-22 22:11:49",
"2024-11-16 19:42:00",
"2024-05-31 03:38:12",
"2024-12-10 12:55:35",
"2024-01-12 04:27:34",
"2024-10-04 21:22:16",
"2024-01-21 21:53:43",
"2024-12-03 00:42:13",
"2024-10-07 22:58:31",
"2024-02-10 02:32:50",
"2024-07-08 09:53:45",
"2024-11-02 08:22:19",
"2024-05-15 09:52:07",
"2024-07-09 11:02:42",
"2024-12-31 00:07:12",
"2024-05-13 02:03:45",
"2024-01-23 19:24:01",
"2024-06-27 23:01:49",
"2024-12-14 21:49:10",
"2024-12-13 19:01:57",
"2024-02-27 08:21:54",
"2024-05-26 03:46:14",
"2024-01-16 18:13:13",
"2024-06-13 22:30:53",
"2024-09-28 03:37:13",
"2024-09-30 05:57:55",
"2024-10-13 01:08:57",
"2024-08-30 00:36:58",
"2024-05-03 23:46:40",
"2024-03-23 18:37:59",
"2024-09-13 12:07:59",
"2024-11-03 05:26:24",
"2024-04-02 17:18:55",
"2024-11-24 23:19:18",
"2024-03-20 00:08:42",
"2024-03-16 09:24:31",
"2024-11-05 21:43:01",
"2024-11-24 18:59:04"
        };


    }
}
