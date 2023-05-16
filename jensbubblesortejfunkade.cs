//prövar att använda bubbelsortering från boken tillsamans med List och inte Lists egne sorteringsalgoritm 
            int saljarlista_length = saljarelista.Count;

            for (int i= saljarlista_length-1; i>0; i--)
            {
                for (int j=0; j<i; j++)
                {
                    if (saljarelista.ElementAt(j).getAntalSalda() > saljarelista.ElementAt(j+1).getAntalSalda())
                    {
                        Saljare t_saljare = saljarelista.ElementAt(j);
                        saljarelista.Insert(j, saljarelista.ElementAt(j + 1));
                        saljarelista.Insert(j + 1, t_saljare);

                    }
                        
                }
            }

            //Trimmar List så den är lika lång som före sorteringen
            int new_length = saljarelista.Count - saljarlista_length;
            saljarelista.RemoveRange(saljarlista_length, new_length);

      
