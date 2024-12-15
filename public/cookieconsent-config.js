import 'https://cdn.jsdelivr.net/gh/orestbida/cookieconsent@3.0.1/dist/cookieconsent.umd.js';

// Enable dark mode
document.documentElement.classList.add('cc--darkmode');

CookieConsent.run({
    guiOptions: {
        consentModal: {
            layout: "box",
            position: "bottom right",
            equalWeightButtons: true,
            flipButtons: false
        },
        preferencesModal: {
            layout: "box",
            position: "right",
            equalWeightButtons: true,
            flipButtons: false
        }
    },
    categories: {
        necessary: {
            readOnly: true
        },
        analytics: {
            services: {
                ga4: {
                    label: 'Google Analytics 4',
                    onAccept: () => {
                        console.log("Analytics consent granted");
                        if (typeof window.gtag === "function") {
                            window.gtag('consent', 'update', {
                                ad_storage: 'granted',
                                ad_user_data: 'granted',
                                ad_personalization: 'granted',
                                analytics_storage: 'granted',
                            });
                        } else {
                            console.error("gtag is not defined. Ensure Google Analytics is loaded.");
                        }
                    },
                    onReject: () => {
                        console.log("Analytics consent denied");
                        if (typeof window.gtag === "function") {
                            window.gtag('consent', 'update', {
                                ad_storage: 'denied',
                                ad_user_data: 'denied',
                                ad_personalization: 'denied',
                                analytics_storage: 'denied',
                            });
                        } else {
                            console.error("gtag is not defined. Ensure Google Analytics is loaded.");
                        }
                    },                    
                    cookies: [
                        {
                            name: /^_ga/,
                            path: '/',
                        },
                    ],
                },
            },
        },
        marketing: {}
    },
    language: {
        default: "en",
        autoDetect: "browser",
        translations: {
            en: {
                consentModal: {
                    title: "Your Privacy Matters to Us",
                    description: "We use cookies to enhance your experience and gather anonymised analytics data to improve our website. We are a non-profit open-source project and will never use your data for advertising or sell it to third parties. For more details, see our <a href=\"/privacy-policy/privacy-policy\">Privacy Policy</a>.",
                    acceptAllBtn: "Accept All Cookies",
                    acceptNecessaryBtn: "Reject Non-Essential Cookies",
                    showPreferencesBtn: "Manage Preferences",
                },
                preferencesModal: {
                    title: "Manage Your Privacy Preferences",
                    acceptAllBtn: "Accept All",
                    acceptNecessaryBtn: "Reject Non-Essential",
                    savePreferencesBtn: "Save Preferences",
                    closeIconLabel: "Close Modal",
                    serviceCounterLabel: "Service|Services",
                    sections: [
                        {
                            title: "Why We Use Cookies",
                            description: "We use cookies to understand how you interact with our website and to improve our resources. Your data will never be used for advertising purposes or shared without your consent."
                        },
                        {
                            title: "Strictly Necessary Cookies <span class=\"pm__badge\">Always Enabled</span>",
                            description: "These cookies are essential for the basic functionality of our website and cannot be disabled."
                        },
                        {
                            title: "Analytics Cookies",
                            description: "Analytics cookies help us gather anonymised data about website usage to improve the user experience. Your data remains secure and is not shared for advertising purposes.",
                            linkedCategory: "analytics"
                        },
                        {
                            title: "Advertisement Cookies",
                            description: "Our website does not use advertisement cookies. We are a non-profit organisation and do not display ads."
                        },
                        {
                            title: "More Information",
                            description: "Please see our <a class=\"cc__link\" href=\"/privacy-policy/privacy-policy\">privacy policy</a> for more information."
                        }
                    ]
                }
            }
        }
    },
    disablePageInteraction: false
});