clear all
clc
seed=1;
y6out=zeros(100,100);
sign3=3*ones(3,1);
seed_arr=randi([1,1000],100,1);
t3_arr=4.4*rand(100,1)+0.1;
k_arr=0.8*rand(100,1)+0.2;
for i=1:100
    seed=seed_arr(i,1);
    t3=t3_arr(i,1);
    k=k_arr(i,1);
    sim("test03.slx");
    for j=1:100
        if y6(j)>4
            y6(j)=4;
        end
    end
    y6out(:,i)=y6;
end
k6_t=y6out(:,1:3);
y6_t=y6out(:,1:80);
save k6.mat k6_t;
save y6.mat y6_t;
% save y3.mat y3_t y3_c;
% stairs(tout,y3_t,'LineWidth',1,'Color','k')
% xlabel("时间（秒）")
% ylabel("输出值（无量纲）")
% 
% 
% 
% y03=[y3_t',sign3];
% fid = fopen('y3.txt','wt');
% [m,n]=size(y03); 
% for i=1:1:m 
% for j=1:1:n 
% if j==n 
% fprintf(fid,'%g\n',y03(i,j)); 
% else 
% fprintf(fid,'%g\t',y03(i,j)); 
% end 
% end 
% end 
% fclose(fid);