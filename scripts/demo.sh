#Updated Script file
#!/bin/bash

# Define variables
repo_version=$(if command -v lsb_release &> /dev/null; then lsb_release -r -s; else grep -oP '(?<=^VERSION_ID=).+' /etc/os-release | tr -d '"'; fi)
dotnet_pkg_url="https://packages.microsoft.com/config/ubuntu/$repo_version/packages-microsoft-prod.deb"
splashkit_url="https://raw.githubusercontent.com/splashkit/skm/master/install-scripts/skm-install.sh"

# Update package lists
sudo apt-get update

# Install required packages
sudo apt-get -y install wget git curl

# Install SplashKit
echo "Installing SplashKit..."
bash <(curl -s $splashkit_url)
echo 'export PATH=$PATH:~/.splashkit' >> ~/.bashrc
export PATH=$PATH:~/.splashkit
yes | skm linux install
if [ -d ~/.splashkit/global ]; then
    echo "Installing SplashKit global"
    skm global install
fi

# Install .NET
echo "Installing .NET..."
wget $dotnet_pkg_url -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt update
sudo apt-get install -y dotnet-sdk-8.0 dotnet-runtime-8.0
echo 'export DOTNET_ROOT=$HOME/.dotnet' >> ~/.bashrc
echo 'export PATH=$PATH:$HOME/.dotnet' >> ~/.bashrc

# Install C++ tools
echo "Installing C++ tools..."
sudo apt-get -y install clang build-essential

# Install VS Code
echo "Installing VS Code..."
wget -O vscode.deb https://go.microsoft.com/fwlink/?LinkID=760868
sudo dpkg -i vscode.deb
sudo apt-get install -f
rm vscode.deb

# Install VS Code extensions
echo "Installing VS Code extensions..."
code --install-extension ms-vscode.cpptools
code --install-extension ms-dotnettools.csharp

echo "Installation complete. Please restart your terminal for changes to take effect."
