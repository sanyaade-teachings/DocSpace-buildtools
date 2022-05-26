import React from "react";
import { observer, inject } from "mobx-react";
import { isMobileOnly } from "react-device-detect";
import { isSmallTablet } from "@appserver/components/utils/device";

const withLoading = (WrappedComponent) => {
  const withLoading = (props) => {
    const {
      isLoadedArticleBody,
      isLoadedArticleHeader,
      isLoadedSectionHeader,
      isLoadedSubmenu,
      isLoadedLngTZSettings,
      isLoadedPortalRenaming,
      isLoadedCustomization,
      isLoadedCustomizationNavbar,
      isLoadedWelcomePageSettings,
    } = props;

    const pathname = location.pathname;
    const index = pathname.lastIndexOf("/");
    const setting = pathname.slice(index + 1);

    const viewMobile = isSmallTablet() || isMobileOnly;

    const isLoadedCustomizationSettings =
      isLoadedCustomization &&
      isLoadedLngTZSettings &&
      isLoadedWelcomePageSettings &&
      isLoadedPortalRenaming &&
      isLoadedArticleBody &&
      isLoadedArticleHeader &&
      isLoadedSectionHeader &&
      isLoadedSubmenu;

    const isLoadedCustomizationNavbarSettings =
      isLoadedCustomizationNavbar &&
      isLoadedArticleBody &&
      isLoadedArticleHeader &&
      isLoadedSectionHeader &&
      isLoadedSubmenu;

    const isLoadedCustomizationSettingLngTZSettings =
      isLoadedArticleBody &&
      isLoadedArticleHeader &&
      isLoadedSectionHeader &&
      isLoadedLngTZSettings;

    const isLoadedCustomizationSettingWelcomePageSettings =
      isLoadedArticleBody &&
      isLoadedArticleHeader &&
      isLoadedSectionHeader &&
      isLoadedWelcomePageSettings;

    const isLoadedCustomizationSettingPortalRenaming =
      isLoadedArticleBody &&
      isLoadedArticleHeader &&
      isLoadedSectionHeader &&
      isLoadedPortalRenaming;

    const isLoadedPage =
      setting === "language-and-time-zone"
        ? isLoadedCustomizationSettingLngTZSettings
        : setting === "welcome-page-settings"
        ? isLoadedCustomizationSettingWelcomePageSettings
        : setting === "portal-renaming"
        ? isLoadedCustomizationSettingPortalRenaming
        : viewMobile
        ? isLoadedCustomizationNavbarSettings
        : isLoadedCustomizationSettings;

    return <WrappedComponent {...props} isLoadedPage={isLoadedPage} />;
  };

  return inject(({ common }) => {
    const {
      isLoadedArticleBody,
      isLoadedArticleHeader,
      isLoadedSectionHeader,
      isLoadedSubmenu,
      isLoadedLngTZSettings,
      isLoadedPortalRenaming,
      isLoadedCustomization,
      isLoadedCustomizationNavbar,
      isLoadedWelcomePageSettings,
    } = common;

    return {
      isLoadedArticleBody,
      isLoadedArticleHeader,
      isLoadedSectionHeader,
      isLoadedSubmenu,
      isLoadedLngTZSettings,
      isLoadedPortalRenaming,
      isLoadedCustomization,
      isLoadedCustomizationNavbar,
      isLoadedWelcomePageSettings,
    };
  })(observer(withLoading));
};
export default withLoading;