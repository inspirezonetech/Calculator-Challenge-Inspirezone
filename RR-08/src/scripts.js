var buttons=document.getElementsByClassName("button");
var display1=document.getElementById("calculation");
var display2=document.getElementById("resultscreen");

for(var i=0;i<buttons.length;i++){
    buttons[i].addEventListener('click',function(){
        var value=this.getAttribute('data-value');
         if(value=='+'||value=='-'||value=='*'||value=='/'){
           
            op1=parseFloat(display2.innerText);
            var end=display2.innerText.slice(-1);
            console.log(end);
            
            if(end=='*'||end=='/'||end==''){
                window.alert("Enter a number");
            }else if(end=='+'||end=='-'){
                window.alert("Enter number");

            }
            else{
                display2.innerText+=value;
            }

        }else if(value=='%'){
            var end=display2.innerText.slice(-1);

            if(end=='+'||end=='-'||end=='*'||end=='/'||end==''){
                window.alert("Invalid input");
            }
            else{
                result=parseFloat(display2.innerText);
            display2.innerText+=value;
            temp=eval(result/100);
            display1.innerText=display2.innerText;
            display2.innerText=temp;
            }
        
        }
        else if(value=='m'){
            display1.innerText="";

            op1=display2.innerText;
            
            if(Array.from(op1)[0]=='-'){
                display2.innerText=op1.substring(1);
            }
            else if(Array.from(op1)[0]=='+'){
                display2.innerText="-"+op1.substring(1);
            }
            else{
                display2.innerText="-"+op1;
            }
        }
        else if(value=='C'){
            display2.innerText="";
            display1.innerText="";
        }
        else if(value=='back'){
            display1.innerText="";
            var back=display2.innerText;
           display2.innerText=back.substring(0,back.length-1);

        }
        else if(value=='='){

        //    op2=parseFloat(display.innerText);
        //    console.log(display.innerText,op2);
        //    result=eval(op1+op2);
           result=parseFloat(eval(display2.innerText));
        //    console.log(result);
        display1.innerText=display2.innerText;
           display2.innerText=result;
        
        }else{
            display2.innerText+=value;
        }
    });
}