using UnityEngine;
using UnityEngine.UI;

namespace Ilumisoft.MergeDice
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private GameObject MainMenuPanel;
        [SerializeField] private GameObject DailyRewardsPanel;
        [SerializeField] private GameObject ExitPanel;
        [SerializeField] private GameObject RateUsPanel;


        [SerializeField] private Button DailyRewardsBtn;
        void Update()
        {
            if (IsReturnButtonDown())
            {
                QuitApplication();
            }
        }

        bool IsReturnButtonDown()
        {
            return Input.GetKeyDown(KeyCode.Escape);
        }

        void QuitApplication()
        {
            Application.Quit();
        }

        public void ShowDailyRewardsPanel()
        {
            MainMenuPanel.SetActive(false);
            DailyRewardsPanel.SetActive(true);
        }
        
        public void ShowMainMenuPanel()
        {
            MainMenuPanel.SetActive(true);
            DailyRewardsPanel.SetActive(false);
        }
        
        public void ShowExitPanel()
        {
            MainMenuPanel.SetActive(false);
            ExitPanel.SetActive(true);
        }
        
        public void CloseExitPanel()
        {
            MainMenuPanel.SetActive(true);
            ExitPanel.SetActive(false);
        }
        
        public void QuitYes()
        {
            Application.Quit();
        }

        public void ShowRatePanel()
        {
            MainMenuPanel.SetActive(false);
            RateUsPanel.SetActive(true);
        }

        public void CloseRatePanel()
        {
            MainMenuPanel.SetActive(true);
            RateUsPanel.SetActive(false);
        }
        
        public void RateYes()
        {
            Application.OpenURL("");
        }
        
        public void ShowPrivacyPolicy()
        {
            Application.OpenURL("");
        }
    }
}