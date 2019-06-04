clear all
clc
seed=1;
y4out=zeros(100,100);
sign5=5*ones(3,1);
seed_arr=randi([1,1000],100,1);
t5_arr=4.4*rand(100,1)+0.1;
for i=1:100
    seed=seed_arr(i,1);
    t5=t5_arr(i,1);
    sim("test05.slx");
    y4out(:,i)=y4;
end
k4_t=y4out(:,1:3);
y4_t=y4out(:,1:80);
save k4.mat k4_t;
save y4.mat y4_t;
% stairs(tout,y5_t,'LineWidth',1,'Color','k')
% xlabel("时间（秒）")
% ylabel("输出值（无量纲）")
% 
% y05=[y5_t',sign5];
% fid = fopen('y5.txt','wt');
% [m,n]=size(y05); 
% for i=1:1:m 
% for j=1:1:n 
% if j==n 
% fprintf(fid,'%g\n',y05(i,j)); 
% else 
% fprintf(fid,'%g\t',y05(i,j)); 
% end 
% end 
% end 
% fclose(fid);