let countBs = (word) => {
    let bcounter = 0;
    
    for(let i = 0; i < word.length; i++){
      if(word.charAt(i) === 'B'){
          bcounter += 1;
      }
    }
        return bcounter;
  }
  
  const countChar = (word, letter) => {
    let lettercounter = 0;
    
    for(let i = 0; i < word.length; i++){
        if(word.charAt(i) === letter){
          lettercounter += 1;
      }
    }
    return lettercounter;
  }
  
  console.log(countBs("BBC"));
  // → 2
  console.log(countChar("She sells SeaShells by the OSean", "S"));
  // → 3