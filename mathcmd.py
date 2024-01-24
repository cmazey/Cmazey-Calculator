import subprocess
import os
import time

try:
    os.chdir('bin/Release/net6.0')

except OSError as e:
    print(f"An error has been occured:: {e}")
    print("\n\nChecking debug bin...")
    time.sleep(2)

    try:
        os.chdir("rere/bin/Debug/net6.0")
    
    except OSError as e:
        print("mathcmd cannot be located in the bin files.")
        
        print("Do you want to run mathcmd.cs file? [.NET 6.0 IS REQUIRED] (y/n)")
        Confirming = input("-> ")

        if Confirming == "y":
            subprocess.call('dotnet run mathcmd.cs', shell=False)
        else:
            print("Application has been interupted, application terminated")
            time.sleep(3)
            
            
try:
    subprocess.call('mathcmd', shell=False)

except subprocess.CalledProcessError:
    print("This is just here cuz why not. Also if u see this, I kinda want to ask [BLANK] if she wanna hang out, idk")