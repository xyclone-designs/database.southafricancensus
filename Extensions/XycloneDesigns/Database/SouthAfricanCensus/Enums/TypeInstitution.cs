using XycloneDesigns.Database.SouthAfricanCensus.Structs;

namespace XycloneDesigns.Database.SouthAfricanCensus.Enums
{
	public static class TypeInstitutionsExtensions
	{
		public static bool FromInt(this TypeInstitution _, int value, Years? year, out TypeInstitution? typeinstitution, out NotAvailables? notavailable)
		{
			notavailable = (value, year) switch
			{
				(99, Years._1996) => NotAvailables.Unspecified,
				(98, Years._1996) => NotAvailables.Institution,

				_ => new NotAvailables?(),
			};

			typeinstitution = (value, year) switch
			{
				(1, Years._1996) => TypeInstitution.TouristHotelMotel,
				(2, Years._1996) => TypeInstitution.ResidentialHotelboardingHouse,
				(3, Years._1996) => TypeInstitution.HomeForTheAged,
				(4, Years._1996) => TypeInstitution.HomeForTheDisabled,
				(5, Years._1996) => TypeInstitution.HospitalMedicalFacilityClinic,
				(6, Years._1996) => TypeInstitution.HostelCompoundForWorkers,
				(7, Years._1996) => TypeInstitution.ShelterForHomelessRefuge,
				(8, Years._1996) => TypeInstitution.SchoolEducationalInstitutionHostel,
				(9, Years._1996) => TypeInstitution.ChildCareInstitutionOrphanage,
				(10, Years._1996) => TypeInstitution.ChildrensCorrectionalInstitution,
				(11, Years._1996) => TypeInstitution.InitiationSchool,
				(12, Years._1996) => TypeInstitution.PrisonCorrectionalServicesInstitution,
				(13, Years._1996) => TypeInstitution.PoliceQuarters,
				(14, Years._1996) => TypeInstitution.NursesOrDoctorsQuarters,
				(15, Years._1996) => TypeInstitution.ChurchHallCommunityCentre,
				(16, Years._1996) => TypeInstitution.ConventMonasteryReligiousRetreat,
				(17, Years._1996) => TypeInstitution.CaravanParkCampingSiteMarina,
				(18, Years._1996) => TypeInstitution.DiplomaticMissionAbroad,
				(19, Years._1996) => TypeInstitution.DefenceForce,
				(20, Years._1996) => TypeInstitution.RefugeeSettlements,
				(21, Years._1996) => TypeInstitution.ShipsInHarbours,
				(22, Years._1996) => TypeInstitution.SouthAfricanIslands,
				(23, Years._1996) => TypeInstitution.BorderPosts,
				(24, Years._1996) => TypeInstitution.Other,

				(1, _) => TypeInstitution.TouristHotelMotel,
				(2, _) => TypeInstitution.ResidentialHotelboardingHouse,
				(3, _) => TypeInstitution.HomeForTheAged,
				(4, _) => TypeInstitution.HomeForTheDisabled,
				(5, _) => TypeInstitution.HospitalMedicalFacilityClinic,
				(6, _) => TypeInstitution.HostelCompoundForWorkers,
				(7, _) => TypeInstitution.ShelterForHomelessRefuge,
				(8, _) => TypeInstitution.SchoolEducationalInstitutionHostel,
				(9, _) => TypeInstitution.ChildCareInstitutionOrphanage,
				(10, _) => TypeInstitution.ChildrensCorrectionalInstitution,
				(11, _) => TypeInstitution.InitiationSchool,
				(12, _) => TypeInstitution.PrisonCorrectionalServicesInstitution,
				(13, _) => TypeInstitution.PoliceQuarters,
				(14, _) => TypeInstitution.NursesOrDoctorsQuarters,
				(15, _) => TypeInstitution.ChurchHallCommunityCentre,
				(16, _) => TypeInstitution.ConventMonasteryReligiousRetreat,
				(17, _) => TypeInstitution.CaravanParkCampingSiteMarina,
				(18, _) => TypeInstitution.DiplomaticMissionAbroad,
				(19, _) => TypeInstitution.DefenceForce,
				(20, _) => TypeInstitution.RefugeeSettlements,
				(21, _) => TypeInstitution.ShipsInHarbours,
				(22, _) => TypeInstitution.SouthAfricanIslands,
				(23, _) => TypeInstitution.BorderPosts,
				(24, _) => TypeInstitution.Other,

				_ => new TypeInstitution?()
			};

			return notavailable is not null || typeinstitution is not null;
		}
	}
}