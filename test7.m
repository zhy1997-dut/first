clear all
clc
seed=1;
y3out=zeros(100,100);
sign7=7*ones(3,1);
am_arr=rand(100,1)+0.1;
wid_arr=randi([4,16],100,1);
delay_arr=randi([2,90],100,1);
seed_arr=randi([1,1000],100,1);
for i=1:100
    amplitude=am_arr(i,1);
    widthp=wid_arr(i,1);
    delay=delay_arr(i,1);
    seed=seed_arr(i,1);
    sim("test07.slx");
    y3out(:,i)=y3;
end
k3_t=y3out(:,1:3);
y3_t=y3out(:,1:80);
stairs(tout,y3_t)
save k3.mat k3_t;
save y3.mat y3_t;
% save y7.mat y7_t y7_c;
% stairs(tout,y7_t,'LineWidth',1,'Color','k')
% xlabel("时间（秒）")
% ylabel("输出值（无量纲）")
% 
% y07=[y7_t',sign7];
% fid = fopen('y7.txt','wt');
% [m,n]=size(y07); 
% for i=1:1:m 
% for j=1:1:n 
% if j==n 
% fprintf(fid,'%g\n',y07(i,j)); 
% else 
% fprintf(fid,'%g\t',y07(i,j)); 
% end 
% end 
% end 
% fclose(fid);