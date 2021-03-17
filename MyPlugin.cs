using AdiIRCAPIv2.Interfaces;

namespace AdiIRC_Plugin_Template
{
    /* Plugin Template
     * by QueenElsa
     * -----------
     * This is a template for coding plugins for the AdiIRC IRC Client.
     * Before using this template, please rename the namespace and class.
     * Your namespace should ideally be similarly named as your plugin. 
     * Your class should be named something that refers to the primary 
     * function of your plugin.
     * -
     * Mar. 2021: 
     * -- Initial release.
     * -
     * You may remove this comment block.
     */

    public class Plugin :IPlugin
    {
        //Set these to your own values.
        public string PluginName => "My Plugin"; /* This will be shown in the plugins window as the name of your plugin. */
        public string PluginDescription => "Just anotheer plugin"; /*Likewise, this will be shown as the description. */
        public string PluginAuthor => "QueenElsa"; /*It's best to use your primary IRC nickname so others can find you. Please don't use my nickname.*/
        public string PluginVersion => "1.0.0"; /*Identify your plugin version here. */
        public string PluginEmail => "myem@il.com"; /*Please use a working email address so others can contact you. */

        //Don't touch the IPluginHost.
        public IPluginHost Client; //Don't change this. You can call the plugin host via Client.

        public void Initialize(IPluginHost pluginHost)
        {
            /* BE NICE!
             * Even though you don't NEED to tell the user that your plugin has loaded, you should ALWAYS inform them.
             * I mean, how would you like it if someone injected a secret plugin into your client and didn't tell you about it?
             */

            Client.ActiveIWindow.OutputText("My Plugin has been loaded successfully. It doesn't do anything yet. I should change that.");
        }

        public void Dispose()
        {
            /* ATTENTION!!!
             * The .NET Framework doesn't allow plugins to be fully unloaded until the application restarts. 
             * So, if your user has unloaded your plugin, it's best to inform them that they need to restart the client.
             * Otherwise, it may surprise them when your plugin keeps functioniong even after they've unloaded it from the 
             * plugins window.
             * 
             * Just some food for thought. 
             */

            Client.ActiveIWindow.OutputText("My Plugin has been unloaded, but I need to restart AdiIRC for it to be fully unloaded.");
        }
    }
}
