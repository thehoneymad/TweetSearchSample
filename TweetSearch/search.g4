grammar Search;

expr: term (op term)*;
term: exactText | hashText | toText | fromText;
op: AND | OR;

toText: 'to:'ID;
fromText: 'from:'ID;
hashText: '#'ID;
exactText: EXACTTEXT;

// lexer rule
EXACTTEXT: '"' ~'"'* '"';
OR: 'OR';
AND: 'AND';
ID: [a-zA-Z_] [a-zA-Z0-9_]*;
WS: [ \n\t\r]+ -> skip;