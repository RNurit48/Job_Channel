using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BLL;
using BO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestJobChannel
{
	[TestClass]
	public class UnitTest1
	{

		Controller c = new Controller();
	
		[TestMethod]
		public void Test_GetAllContrats()
		{
			List<Contrat> expected = new List<Contrat>();

			expected.Add(new Contrat { Type = "CDI" });
			expected.Add(new Contrat { Type = "CDD" });
			expected.Add(new Contrat { Type = "STAGE" });
			expected.Add(new Contrat { Type = "CONTRAT PRO" });

			List<Contrat> actual = new List<Contrat>();
			actual.AddRange(c.GetAllContrats());


			CollectionAssert.AreEqual(expected, actual);

		}

		[TestMethod]
		public void Test_GetAllRegion()
		{
			List<Region> expected = new List<Region>();

			expected.Add(new Region { Nom = "OCCITANIE" });
			expected.Add(new Region { Nom = "NORMANDIE" });
			expected.Add(new Region { Nom = "CORSE" });
			expected.Add(new Region { Nom = "BRETAGNE" });

			List<Region> actual = new List<Region>();
			actual.AddRange(c.GetAllRegions());


			CollectionAssert.AreEquivalent(expected, actual);

		}

		[TestMethod]
		public void Test_GetAllPoste()
		{
			List<Poste> expected = new List<Poste>();

			expected.Add(new Poste { Type = "DEVELOPPEUR FRONT-END" });
			expected.Add(new Poste { Type = "DEVELOPPEUR BACK-END" });
			expected.Add(new Poste { Type = "TECHNICIEN RESEAU" });
			expected.Add(new Poste { Type = "TECHNICIEN ASSISTANCE" });

			List<Poste> actual = new List<Poste>();
			actual.AddRange(c.GetAllPostes());


			CollectionAssert.AreEquivalent(expected, actual);

		}


		[TestMethod]
		public void Test_PostOffre()
		{
			Offre expected = new Offre { Titre = "test1", Description = "test1", DatePublication = DateTime.Today, Region = new Region { Id_Region = 1, Nom = "OCCITANIE"}, Contrat = new Contrat { Id_Contrat = 1,Type= "CDI" }, Poste = new Poste { Id_Poste = 1, Type = "DEVELOPPEUR FRONT-END" }, Lien = " "};
			c.PostOffre(expected);
			
			List<Offre> actual = new List<Offre>();
			actual.AddRange(c.GetAllOffres());


			CollectionAssert.Contains(actual,expected);

		}

		[TestMethod]
		public void Test_UpdateOffre()
		{
			Offre expected = new Offre { Titre = "updatetest", Description = "test1", DatePublication = DateTime.Today, Region = new Region { Id_Region = 1, Nom = "OCCITANIE" }, Contrat = new Contrat { Id_Contrat = 1, Type = "CDI" }, Poste = new Poste { Id_Poste = 1, Type = "DEVELOPPEUR FRONT-END" }, Lien = " ", NumOffre = 31 };
			 c.UpdateOffre(expected);
			
			List<Offre> actual = new List<Offre>();
			actual.AddRange(c.GetAllOffres());

			
			CollectionAssert.Contains(actual, expected);

		}

		[TestMethod]
		public void Test_DeleteOffre()
		{
			Offre expected = new Offre { NumOffre = 31 };
			c.DeleteOffre(expected);

			List<Offre> actual = new List<Offre>();
			actual.AddRange(c.GetAllOffres());


			CollectionAssert.DoesNotContain(actual, expected);

		}

	}
}
