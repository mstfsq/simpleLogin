Imports System




Module Program
    
    dim userName, password, newUser, iUser , iPword  as string
    dim i as integer
    
    
    Sub Main(args As String())
          
        
        ' declaring variables
        username = "d16661"
        password = "Mustafa123"
        i = 3
             
        
        
        ' asking for username 
        Console.WriteLine("Welcome to Mustafas's Bank.Please enter your username")
        iUser = console.ReadLine()
        
        
        ' if the username checks out is asks for password 
        if iUser = username Then
            Console.WriteLine("Welcome back " & userName & ",please input your password")
            iPword = console.ReadLine()
            
            ' if pword does not match it goes into a precondition loop until the pword is correct or they finished the 3 attmepts 
            if ipword <> password 
           
                do 
                    i = i-1
                    
                    Console.WriteLine("Incorrect Password,Please try again " & i & " attempts remaining")
                    
                
                    ipword = Console.ReadLine()
        
                loop until ipword = password or i = 1
                
             end if    
                
            
            ' if the attempts finish account gets locked
            if i=1
                Console.WriteLine("Account Locked")
            
            ' if the password is correct then it logs in 
            else if iPword = password then    
            Console.WriteLine("Welcome to Mustafa's Open Banking")
            Console.readline()
                
            end if     
            
         ' if username does not check out it goes here   
        else
            
            Console.WriteLine("You do not have an account open with us. Please visit your closest branch with Government ID")
            Console.ReadLine()
            
          
            
            
            
        End If
        
        
        
        
        
        
        
    End Sub
End Module
