using Computer_Science_NEA_FINAL.Resources;

namespace Computer_Science_NEA_FINAL
{
    class FormProvider
    {
        public static int userType;
        public static Main_Menu MainMenu
        {
            get
            {
                if (_mainMenu == null)
                {
                    _mainMenu = new Main_Menu();
                }
                return _mainMenu;
            }
        }

        public static LocationForm LocationForm
        {
            get
            {
                if(locationForm == null)
                {
                    locationForm = new LocationForm();
                }
                return locationForm;
            }
        }

        public static BlogForm BlogForm
        {
            get
            {
                if (blogForm == null)
                {
                    blogForm = new BlogForm();
                }
                return blogForm;
            }
        }

        public static CubDetailsFormLeaders CubDetailsFormLeaders
        {
            get
            {
                if (cubDetailsFormLeaders == null)
                {
                    cubDetailsFormLeaders = new CubDetailsFormLeaders();
                }
                return cubDetailsFormLeaders;
            }
        }

        public static GalleryForm GalleryForm
        {
            get
            {
                if (galleryForm == null)
                {
                    galleryForm = new GalleryForm();
                }
                return galleryForm;
            }
        }

        public static ItineraryForm ItineraryForm
        {
            get
            {
                if (itineraryForm == null)
                {
                    itineraryForm = new ItineraryForm();
                }
                return itineraryForm;
            }
        }

        public static LeadersForm LeadersForm
        {
            get
            {
                if (leadersForm == null)
                {
                    leadersForm = new LeadersForm();
                }
                return leadersForm;
            }
        }

        public static MedicalForm MedicalForm
        {
            get
            {
                if (medicalForm == null)
                {
                    medicalForm = new MedicalForm();
                }
                return medicalForm;
            }
        }

        public static Menu_Form Menu_Form
        {
            get
            {
                if (menu_Form == null)
                {
                    menu_Form = new Menu_Form();
                }
                return menu_Form;
            }
        }

        public static SixesForm SixesForm
        {
            get
            {
                if (sixesForm == null)
                {
                    sixesForm = new SixesForm();
                }
                return sixesForm;
            }
        }

        public static PastCampsForm PastCampsForm
        {
            get
            {
                if (pastCampsForm == null)
                {
                    pastCampsForm = new PastCampsForm();
                }
                return pastCampsForm;
            }
        }

        ////////////
        private static Main_Menu _mainMenu;
        private static LocationForm locationForm;
        private static BlogForm blogForm;
        private static CubDetailsFormLeaders cubDetailsFormLeaders;
        private static GalleryForm galleryForm;
        private static ItineraryForm itineraryForm;
        private static LeadersForm leadersForm;
        private static MedicalForm medicalForm;
        private static Menu_Form menu_Form;
        private static SixesForm sixesForm;
        private static PastCampsForm pastCampsForm;
        ////////////

    }
}
