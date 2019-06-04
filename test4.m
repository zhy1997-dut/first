clear all
clc
seed=1;
y5out=zeros(100,100);
sign4=4*ones(3,1);
seed_arr=randi([1,1000],100,1);
t_arr=4.4*rand(100,1)+0.1;
for i=1:100
    seed=seed_arr(i,1);
    t=t_arr(i,1);
    sim("test04.slx");
    y5out(:,i)=y5;
end
k5_t=y5out(:,1:3);
y5_t=y5out(:,1:80);
save k5.mat k5_t;
save y5.mat y5_t;
% save y4.mat y4_t y4_c;
% stairs(tout,y4_t,'LineWidth',1,'Color','k')
% xlabel("时间（秒）")
% ylabel("输出值（无量纲）")
% 
% 
% 
% y04=[y4_t',sign4];
% fid = fopen('y4.txt','wt');
% [m,n]=size(y04); 
% for i=1:1:m 
% for j=1:1:n 
% if j==n 
% fprintf(fid,'%g\n',y04(i,j)); 
% else 
% fprintf(fid,'%g\t',y04(i,j)); 
% end 
% end 
% end 
% fclose(fid);