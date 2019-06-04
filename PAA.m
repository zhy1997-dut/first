function test_PAA=PAA(test,n)

[k,m]=size(test);
test_PAA=zeros(k,n);
if(mod(m,n)==0)
    k1=m/n;
    for i=1:k
        for j=1:n
            test_PAA(i,j)=mean(test(i,1+k1*(j-1):k1*j));
        end
    end
else
    k1=fix(m/n);
    k2=k1+1;
    for i=1:k
        for j=1:m-k1*n
            test_PAA(i,j)=mean(test(i,k2*(j-1)+1:k2*j));
        end
        for j=m-k1*n+1:n
            test_PAA(i,j)=mean(test(i,k1*(j-n-1)+m+1:k1*(j-n)+m));
        end
    end
end
