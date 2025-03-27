using System;

public interface IPlayable{
    void Play();
    void Pause();
    void Stop();
}

public class MusicPlayer : IPlayable{
    
    private bool isPlaying = false;
    
    public void Play(){
        if(!isPlaying){
            
            isPlaying = true;
            
            Console.WriteLine("\n\tPlaying music...");
        }
        else{
            Console.WriteLine("\n\tMusic is already playing.");
        }
    }

    public void Pause(){
        if(isPlaying){
            isPlaying = false;
            Console.WriteLine("\n\tPausing the music...");
        }
        else{
            Console.WriteLine("\n\tCannot pause the music. Either there is currently no music being played or the music was already paused.");
        }
    }

    public void Stop(){
        if(isPlaying){
            isPlaying = false;
            Console.WriteLine("\n\tStopping the music...");
        }
        else{
            Console.WriteLine("\n\tCannot pause the music. Either there is currently no music being played or the music was already paused.");
        }
    }
}

public class VideoPlayer : IPlayable{
    
    private bool isPlaying = false;
    
    public void Play(){
        if(!isPlaying){
            
            isPlaying = true;
            
            Console.WriteLine("\n\tPlaying video...");
        }
        else{
            Console.WriteLine("\n\tVideo is already playing.");
        }
    }

    public void Pause(){
        if(isPlaying){
            isPlaying = false;
            Console.WriteLine("\n\tPausing the video...");
        }
        else{
            Console.WriteLine("\n\tCannot pause the video. Either there is currently no video being played or the video was already paused.");
        }
    }

    public void Stop(){
        if(isPlaying){
            isPlaying = false;
            Console.WriteLine("\n\tStopping the music...");
        }
        else{
            Console.WriteLine("\n\tCannot pause the video. Either there is currently no video being played or the video was already paused.");
        }
    }
}

public class Program{
    public static void Main(string[] args){
        
        IPlayable musicPlayer = new MusicPlayer();
        IPlayable videoPlayer = new VideoPlayer();
        
        int action = 0;
        char choice = 'y';
        
        do{
            Console.WriteLine("\n1. Music Player\n2. Video Player\n");
            
            Console.Write("Enter the player number of your choice: ");
            int num = Convert.ToInt32(Console.ReadLine());
    
            if(num == 1){
                Console.WriteLine("\nMusic Player");
                Console.WriteLine("\n\t1. Play\n\t2. Pause\n\t3. Stop");
                Console.Write("\nChoose the action that you want to take: ");
                action = Convert.ToInt32(Console.ReadLine());
                
                switch(action){
                    case 1:
                        musicPlayer.Play();
                        break;
                    case 2:
                        musicPlayer.Pause();
                        break;
                    case 3:
                        musicPlayer.Stop();
                        break;
                    default:
                        Console.Write("Number of choice not included in the list. Do you want to try again? y/n: ");
                        action = Convert.ToChar(Console.ReadLine());
                        break;
                }
            }
            else if(num == 2){
                Console.WriteLine("\nVideo Player:");
                Console.WriteLine("\n\t1. Play\n\t2. Pause\n\t3. Stop");
                Console.Write("\nChoose the action that you want to take: ");
                action = Convert.ToInt32(Console.ReadLine());
                
                switch(action){
                    case 1:
                        videoPlayer.Play();
                        break;
                    case 2:
                        videoPlayer.Pause();
                        break;
                    case 3:
                        videoPlayer.Stop();
                        break;
                    default:
                        Console.Write("Number of choice not included in the list. Do you want to try again? y/n: ");
                        choice = Convert.ToChar(Console.ReadLine());
                        break;
                }
            }
            else{
                Console.WriteLine("\nInvalid input, please try again.");
            }
            
            Console.Write("\n\nEnter 'y' if you want to do another change, otherwise enter press any other keys: ");
            choice = Convert.ToChar(Console.ReadLine());
            
        } while(choice == 'y' || choice == 'Y');
        

    }
}