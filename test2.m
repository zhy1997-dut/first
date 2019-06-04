clear all
clc
seed=1;
y2out=zeros(100,100);
sign2=2*ones(3,1);
seed_arr=randi([1,1000],100,1);
t2_arr=4.4*rand(100,1)+0.1;
c2_arr=rand(100,1)+0.1;
for i=1:100
    seed=seed_arr(i,1);
    t2=t2_arr(i,1);
    c2=c2_arr(i,1);
    sim("test02.slx");
    y2out(:,i)=y2;
end
k2_t=y2out(:,1:3);
y2_t=y2out(:,1:80);
save k2.mat k2_t;
save y2.mat y2_t;
% save y2.mat y2_t y2_c;
stairs(tout,k2_t,'LineWidth',1,'Color','k')
% xlabel("时间（秒）")
% ylabel("输出值（无量纲）")
% 
% 
% 
% y02=[y2_t',sign2];
% fid = fopen('y2.txt','wt');
% [m,n]=size(y02); 
% for i=1:1:m 
% for j=1:1:n 
% if j==n 
% fprintf(fid,'%g\n',y02(i,j)); 
% else 
% fprintf(fid,'%g\t',y02(i,j)); 
% end 
% end 
% end 
% fclose(fid);