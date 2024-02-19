using CODWloadoutsAPI.Models;
using HtmlAgilityPack;
using System.Collections.Generic;

namespace CODWloadoutsAPI
{
    public class WebScraping()
    {
        public static List<WeaponModel> GetWeapon()
        {
            var web = new HtmlWeb();
            var document = web.Load("https://www.wzranked.com/wz2/meta");

            var weapons = new List<WeaponModel>();
            var AllLi = document.DocumentNode.QuerySelector("ul.space-y-1").QuerySelectorAll("li");
            int i = 0;
            foreach (var li in AllLi)
            {
                var name = li.QuerySelector("span.truncate").InnerText;

                var weaponClass = li.QuerySelector("p.whitespace-nowrap").InnerText;

                var useIt = li.QuerySelector("div.flex.gap-x-1.text-xs.text-custom-text-secondary").InnerText;
                i++;
                

                weapons.Add(new WeaponModel {Id = Guid.NewGuid(), Name = name, Class = weaponClass, UseIt = useIt, Rank = i});
            }

            return weapons;
        }

        public static List<TopPlayer> GetTopPlayer()
        {
            var web = new HtmlWeb();
            var document = web.Load("https://www.wzranked.com/wz2/leaderboards/top250");

            var topPlayers = new List<TopPlayer>();
            var AllLi = document.DocumentNode.QuerySelector("ul.space-y-1").QuerySelectorAll("li");
            int i = 0;
            foreach (var li in AllLi)
            {
                var name = li.QuerySelector("span.truncate").InnerText;

                var srTotal = li.QuerySelector("div.flex.items-center.gap-x-1.text-sm.font-medium.tabular-nums.leading-none.text-custom-text-primary").InnerText+" SR";
                var srToday = li.QuerySelector("div.whitespace-nowrap.text-xs.tabular-nums.text-custom-text-secondary").InnerText;

                i++;


                topPlayers.Add(new TopPlayer { Id = Guid.NewGuid(), Name = name, SRTotal = srTotal, SRToday = srToday, Rank = i });
            }

            return topPlayers;
        }
    }
}
